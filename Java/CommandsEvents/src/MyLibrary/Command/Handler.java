package MyLibrary.Command;

import MyLibrary.ICommand;

public abstract class Handler<TCommand extends ICommand, TResponse> implements IHandler<TCommand, TResponse>
{
    public abstract TResponse Handle(TCommand command);
}
