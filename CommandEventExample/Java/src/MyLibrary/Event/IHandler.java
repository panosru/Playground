package MyLibrary.Event;

public interface IHandler<TEvent> {
    public void Handle(TEvent event);
}
