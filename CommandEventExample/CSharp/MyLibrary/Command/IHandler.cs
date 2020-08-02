namespace MyLibrary.Command
{
    public interface IHandler<in TCommand, out TResponse>
        where TCommand : ICommand<TResponse>
    {
        public TResponse Handle(TCommand command);
    }
}