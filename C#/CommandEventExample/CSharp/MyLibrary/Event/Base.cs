namespace MyLibrary.Event
{
    using System;
    
    public abstract class Base<TPayload> : IEvent<TPayload>
        where TPayload : IPayload
    {
        public TPayload Payload { get; private set; }
				
        public DateTime Occurred { get; private set; } = DateTime.Now;

        protected Base(TPayload payload)
        {
            Payload = payload;
        }
    }
}