namespace MyLibrary
{
    public interface IEvent<TPayload>
        where TPayload : IPayload
    {
    }
}