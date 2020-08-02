namespace MyApp.Events
{
    using System;
    
    public sealed class Fooed : MyLibrary.Event.Base<Payloads.Foo>
    {
        public Fooed(Payloads.Foo payload) : base(payload)
        {}
    }
    
    public sealed class FooedHandler : MyLibrary.Event.Handler<Fooed>
    {
        public override void Handle(Fooed evnt)
        {
            Console.WriteLine($"Fooed event fired with payload: \"{@evnt.Payload.Value}\"");
        }
    }
}