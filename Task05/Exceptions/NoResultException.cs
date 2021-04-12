using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Task05.Exceptions
{
    public class NoResultException : Exception
    {
        public NoResultException()
        {
        }

        public NoResultException(string message) : base(message)
        {
        }

        public NoResultException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoResultException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
