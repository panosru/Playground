package MyApp.Events;

import MyLibrary.Event.Handler;

public final class FooedHandler extends Handler<Fooed> {

    @Override
    public void Handle(Fooed fooed) {
        System.out.println(String.format("Fooed event fired with payload: \"%s\"", fooed.Payload().Value()));
    }
}
