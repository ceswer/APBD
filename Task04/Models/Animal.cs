using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task04.Models
{
    public class Animal
    {
        [Required(ErrorMessage = "IdAnimal should not nullable!")]
        public int IdAnimal { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Name should not nullable!")]
        public string Name { get; set; }
        // Note: nullable 
        [MaxLength(200)]
        public string Description { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Category should not be nullable!")]
        public string Category { get; set; }
        [MaxLength(500)]
        [Required(ErrorMessage = "Area should not be nullable!")]
        public string Area { get; set; }
    }
}
