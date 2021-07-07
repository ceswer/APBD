using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task08.Models
{
    public class Prescription
    {
        public Prescription()
        {
            PrescriptionMedicaments = new HashSet<PrescriptionMedicament>();
        }


        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }


        public virtual Patient IdPatientNav { get; set; }
        public virtual Doctor IdDoctorNav { get; set; }


        public virtual ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    }
}
