using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Classes
{
    class DublicatedStudentException : Exception
    {
        public DublicatedStudentException(String message) : base(message) {}
    }
}
