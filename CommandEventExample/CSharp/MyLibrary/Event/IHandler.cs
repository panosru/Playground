namespace MyLibrary.Event
{
    public interface IHandler<in TEvent>
    {			
        public void Handle(TEvent evnt);
    }
}