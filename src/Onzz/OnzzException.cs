using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Onzz
{
    [Serializable]
    public class OnzzException : Exception
    {
        /// <summary>
        /// Creates a new <see cref="OnzzException"/> object.
        /// </summary>
        public OnzzException()
        {

        }
        /// <summary>
        /// Creates a new <see cref="OnzzException"/> object.
        /// </summary>
        public OnzzException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }
        /// <summary>
        /// Creates a new <see cref="OnzzException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public OnzzException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Creates a new <see cref="OnzzException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public OnzzException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
