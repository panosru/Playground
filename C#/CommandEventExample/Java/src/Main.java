import MyApp.Commands.Foo;
import MyApp.Commands.FooHandler;

public class Main
{
    public static void main(String[] args) {
        (new FooHandler())
                .Handle(new Foo("Hello"));
    }
}
