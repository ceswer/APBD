using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Task05.Exceptions
{
    public class SomethingWentWrongException : Exception
    {
        public SomethingWentWrongException()
        {
        }

        public SomethingWentWrongException(string message) : base(message)
        {
        }

        public SomethingWentWrongException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SomethingWentWrongException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
