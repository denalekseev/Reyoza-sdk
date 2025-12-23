using System;
using System.Net;
using System.Runtime.Serialization;
using Restub;

namespace ReyozaSdk
{
    /// <summary>
    /// Reyoza Exception.
    /// </summary>
    [Serializable]
    public class ReyozaException : RestubException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReyozaException"/> class.
        /// </summary>
        /// <param name="code">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="innerException">Inner <see cref="Exception"/> instance.</param>
        public ReyozaException(HttpStatusCode code, string message, Exception innerException)
            : base(code, GetMessage(code, message), innerException)
        {
        }

        private static string GetMessage(HttpStatusCode code, string message)
        {
            if (!string.IsNullOrWhiteSpace(message))
            {
                return message;
            }

            return code.ToString();
        }

        /// <inheritdoc/>
        protected ReyozaException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <inheritdoc/>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
