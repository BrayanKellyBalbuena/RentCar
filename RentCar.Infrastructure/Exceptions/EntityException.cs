using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Infrastructure.Exceptions
{
    public class EntityException : Exception
    {
        public EntityException(): base(){}
        public EntityException(string message) : base(message){}
        public EntityException(string message, Exception exception) :base(message, exception) {}
        public EntityException(SerializationInfo serialization, StreamingContext streamingContext)
            : base(serialization, streamingContext) {}
    }
}
