using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task08.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Prescriptions = new HashSet<Prescription>();
        }


        public int IdDoctor { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
