using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task11.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string URLToPhoto { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Studies { get; set; }
    }
}
