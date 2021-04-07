using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    public class University
    {
        public string Name { get; set; }
        public HashSet<Student> studentHashSet;

        public University(string name, HashSet<Student> studentHashSet)
        {
            this.Name = name;
            this.studentHashSet = studentHashSet;
        }
    }
}
