package MyApp.Events;

import MyApp.Payloads.Foo;
import MyLibrary.Event.Base;

public final class Fooed extends Base<Foo> {

    public Fooed(Foo payload) {
        super(payload);
    }
}
