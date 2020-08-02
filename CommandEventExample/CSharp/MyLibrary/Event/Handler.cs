namespace MyLibrary.Event
{
    public abstract class Handler<TEvent> : IHandler<TEvent>
    {				
        public abstract void Handle(TEvent evnt);
    }
}