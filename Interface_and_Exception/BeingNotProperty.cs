using System;

namespace NInterface_and_Exception
{
    [Serializable()]
    public class BeingNotProperty : Exception
    {
        public BeingNotProperty() : base() { }
        public BeingNotProperty(string message) : base(message) { }
        public BeingNotProperty(string message, System.Exception inner) : base(message, inner) { }
        protected BeingNotProperty(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
