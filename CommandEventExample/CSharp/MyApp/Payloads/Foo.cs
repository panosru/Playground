namespace MyApp.Payloads
{
    using MyLibrary;
    
    public sealed class Foo : IPayload
    {
        public string Value { get; private set; }

        public Foo(string val)
        {
            Value = val;
        }
    }
}