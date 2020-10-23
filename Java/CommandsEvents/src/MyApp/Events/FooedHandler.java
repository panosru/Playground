package MyApp.Events;

import MyLibrary.Event.Handler;

public final class FooedHandler extends Handler<Fooed>
{
    @Override
    public void Handle(Fooed fooed)
    {
        System.out.printf("Fooed event fired with payload: \"%s\"%n", fooed.Payload().Value());
    }
}
