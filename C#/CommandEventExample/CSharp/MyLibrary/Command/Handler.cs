namespace MyLibrary.Command
{
    public abstract class Handler<TCommand, TResponse> : IHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse>
    {
        public abstract TResponse Handle(TCommand command);
    }
}