using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task03.Models
{
    public class Student
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime Birthdate { get; set; }
        [Required]
        public string Study { get; set; }
        [Required]
        public string Mode { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string MotherName { get; set; }

        public override string ToString()
        {
            return $"{Name},{Surname},{ID},{Birthdate},{Study},{Mode},{Email},{FatherName},{MotherName}";
        }
    }
}
