using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Task05.Exceptions
{
    public class NoRowsException : Exception
    {
        public NoRowsException()
        {
        }

        public NoRowsException(string message) : base(message)
        {
        }

        public NoRowsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoRowsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
