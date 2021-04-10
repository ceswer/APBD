using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleFirstFinal2020.Models
{
    public class ProcedureAnimal
    {
        [Required]
        public int IdProcedure { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
