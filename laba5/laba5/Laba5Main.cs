using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
namespace laba5
{
    class Laba5Main
    {

        bool isSortByDisciline = false;
        bool isSortByLecturer = false;

        private Dictionary<string, Lecturer> lecturersSet = new Dictionary<string, Lecturer>();
        private Dictionary<string, Discipline> disciplinesSet = new Dictionary<string, Discipline>();

        public List<CrutchCortege> data { get; set; } = new List<CrutchCortege>();
        public BindingSource binding { get; set; } = new BindingSource();
        public Laba5Main()
        {

            defaultInitialization();
            binding.DataSource = data;
        }

        public void sortByLecturer()
        {
            if (!isSortByLecturer)
            {
                data.Sort(Comparer<CrutchCortege>.Create((x, y) =>
                   (x as CrutchCortege).lecturer.name.CompareTo(
                   (y as CrutchCortege).lecturer.name)));
                isSortByLecturer = true;
                isSortByDisciline = false;
            }
            else
            {
                isSortByLecturer = false;
                isSortByDisciline = false;
                data.Reverse();
            }
            binding.ResetBindings(true);
        }
        public void sortByDscipline()
        {

            if (!isSortByDisciline)
            {
                data.Sort(Comparer<CrutchCortege>.Create((x, y) =>
                       (x as CrutchCortege).discipline.name.CompareTo(
                       (y as CrutchCortege).discipline.name)));
                isSortByDisciline = true;
                isSortByLecturer = false;
            }
            else
            {
                data.Reverse();
                isSortByDisciline = false;
                isSortByLecturer = false;
            }
            binding.ResetBindings(true);
        }
        public void addCortege(Lecturer lecturer, Discipline discipline)
        {
            if (!(lecturersSet.Keys.Contains(lecturer.name)) &&
                    !disciplinesSet.Keys.Contains(discipline.name))
            {
                lecturersSet.Add(lecturer.name, lecturer);
                disciplinesSet.Add(discipline.name, discipline);
                data.Add(new CrutchCortege(lecturer, discipline));
                binding.ResetBindings(true);
            }
        }
        public void removeDiscipline(string name)
        {
            data.RemoveAll(cortege => cortege.discipline.name.Equals(name));
            binding.ResetBindings(true);
        }
        public void removeLecturer(string name)
        {
            data.RemoveAll(cortege => cortege.lecturer.name.Equals(name));
            binding.ResetBindings(true);
        }
        public void changeCortege(int index)
        {
            if (!disciplinesSet.Keys.Contains(data[index].discipline.name))
            {
                disciplinesSet.Add(
                    data[index].discipline.name,
                    data[index].discipline);
            }
            if (!lecturersSet.Keys.Contains(data[index].lecturer.name))
            {
                lecturersSet.Add(
                    data[index].lecturer.name,
                    data[index].lecturer);
            }

            binding.ResetBindings(true);
        }
        public void doXMLSerialize()
        {
            using (FileStream file = new FileStream("C:/file.xml", FileMode.Create))
            {
                new XmlSerializer(typeof(List<CrutchCortege>)).Serialize(file, data);
            }
        }
        public void doXMLDeserialize()
        {
            using (FileStream file = new FileStream("C:/file.xml", FileMode.Open))
            {
                data = new XmlSerializer(typeof(List<CrutchCortege>)).Deserialize(file) as List<CrutchCortege>;
                binding.DataSource = data;
            }
        }


        private void defaultInitialization()
        {
            lecturersSet.Add("1", new Lecturer("1"));
            lecturersSet.Add("2", new Lecturer("2"));
            lecturersSet.Add("3", new Lecturer("12"));
            lecturersSet.Add("4", new Lecturer("14"));
            lecturersSet.Add("5", new Lecturer("15"));
            lecturersSet.Add("6", new Lecturer("16"));
            string s = "1";
            disciplinesSet.Add(s, new Discipline(s));

            data.Add(new CrutchCortege(lecturersSet["1"], disciplinesSet["1"]));
            data.Add(new CrutchCortege(lecturersSet["2"], disciplinesSet["1"]));
            data.Add(new CrutchCortege(lecturersSet["3"], disciplinesSet["1"]));
            data.Add(new CrutchCortege(lecturersSet["4"], disciplinesSet["1"]));
            data.Add(new CrutchCortege(lecturersSet["5"], disciplinesSet["1"]));
            data.Add(new CrutchCortege(lecturersSet["6"], disciplinesSet["1"]));
            data.Add(new CrutchCortege(lecturersSet["1"], disciplinesSet["1"]));
        }

    }
}
