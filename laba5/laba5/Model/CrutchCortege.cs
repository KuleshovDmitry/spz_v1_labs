using System;

namespace laba5
{
    public class CrutchCortege
    {
        public Lecturer lecturer { get; set; }
        public Discipline discipline { get; set; }
        public CrutchCortege()
        {
            lecturer = new Lecturer();
            discipline = new Discipline();
        }
        public CrutchCortege(Lecturer lecturer, Discipline discipline)
        {
            this.lecturer = lecturer;
            this.discipline = discipline;
        }
        public bool isThisLecturer(string lecturerName)
        {
            return this.lecturer.name.Equals(lecturerName);
        }
        public bool isThisDiscipline(string disciplineName)
        {
            return this.discipline.name.Equals(disciplineName);
        }
        public override string ToString()
        {
            return lecturer.ToString() + ' ' + discipline.ToString();
        }
    }

}
