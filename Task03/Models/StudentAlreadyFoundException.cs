using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task03.Models
{
    public class StudentAlreadyFoundException : Exception
    {
        public StudentAlreadyFoundException(string message) : base(message) { }
    }
}
