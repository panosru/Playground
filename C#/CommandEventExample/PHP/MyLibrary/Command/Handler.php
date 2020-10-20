<?php

declare(strict_types=1);


namespace MyLibrary\Command;

use MyLibrary\ICommand;

abstract class Handler implements IHandler
{
    public abstract function Handle(ICommand $command);
}
