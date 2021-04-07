using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
        public string Mode { get; set; }
        public int Number { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

       // Note: I don`t know what type of properties are Alina and Adam (duplicated in all students)
       // Do not throw exception

        public string Alina { get; set; }
        public string Adam { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {Department} {Mode} {Number} {DateOfBirth.ToString()} {Email} {Alina} {Adam}";
        }
    }
}
