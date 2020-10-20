package MyLibrary.Event;

public abstract class Handler<TEvent> implements IHandler<TEvent> {

    public abstract void Handle(TEvent event);
}
