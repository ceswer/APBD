using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task03.Models
{
    public class NotModyfingPropertyException : Exception
    {
        public NotModyfingPropertyException(string message) : base(message) { }
    }
}
