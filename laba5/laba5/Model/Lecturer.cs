using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Lecturer 
    {
        public string name { set; get; }
        private HashSet<Discipline> disciplinesSet = new HashSet<Discipline>();
        public Lecturer()
        {
            name = "";
        }
        public Lecturer(string name)
        {
            this.name = name;
        }
        public Lecturer(string name, Discipline[] disciplines):this(name)
        {
            disciplinesSet.Concat(disciplines);
        }
        public HashSet<Discipline> getDisciplines()
        {
            return disciplinesSet;
        }
        public void delteDiscipline(Discipline discipline)
        {
            disciplinesSet.Remove(discipline);
        }
        public override string ToString()
        {
            return name;
        }
       

    }
}
