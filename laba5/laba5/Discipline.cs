using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class Discipline
    {
        public string name { set; get; }
        public Discipline()
        {
            name = "";
        }
        public Discipline(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
        
    }
}
