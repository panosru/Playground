package MyApp.Commands;

import MyApp.Events.Fooed;
import MyApp.Events.FooedHandler;
import MyLibrary.Command.Handler;

public final class FooHandler extends Handler<Foo, String>
{
    @Override
    public String Handle(Foo command)
    {
        // Some logic
        System.out.println("Foo command handled");

        String result = String.format("%s, %s", command.Greeting(), command.Value());

        // Obviously we will have an even emitter that will fire the event in real world
        (new FooedHandler())
                .Handle(new Fooed(new MyApp.Payloads.Foo(result)));

        return result;
    }
}
