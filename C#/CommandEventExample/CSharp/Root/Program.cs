namespace Root
{
    class Program
    {
        static void Main(string[] args)
        {
            (new MyApp.Commands.FooHandler())
                .Handle(new MyApp.Commands.Foo("Hello"));
        }
    }
}