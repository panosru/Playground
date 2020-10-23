package MyLibrary.Command;

import MyLibrary.ICommand;

public interface IHandler<TCommand extends ICommand, TResponse>
{
    public TResponse Handle(TCommand command);
}
