namespace MyApp.Commands
{
    using System;
    
    public sealed class Foo : MyLibrary.Command.Base<string>
    {
        public string Greeting { get; private set; }
        public string Value { get; private set; } = "World";

        public Foo(string greeting)
        {
            Greeting = greeting;
        }
    }
    
    public sealed class FooHandler : MyLibrary.Command.Handler<Foo, string>
    {
        public override string Handle(Foo command)
        {
            // Some logic
            Console.WriteLine("Foo command handled");
				
            string result = $"{command.Greeting}, {command.Value}";
				
            // Obviously we will have an even emiter that will fire the event in real world
            (new Events.FooedHandler())
                .Handle(new Events.Fooed(new Payloads.Foo(result)));
				
            return result;
        }
    }
}