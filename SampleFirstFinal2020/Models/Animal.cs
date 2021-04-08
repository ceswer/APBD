using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleFirstFinal2020.Models
{
    public class Animal
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public DateTime AdmissionDate  { get; set; }
        [Required]
        public int IdOwner { get; set; }
        public IEnumerable<ProcedureAnimal> Procedures { get; set; }
    }
}
