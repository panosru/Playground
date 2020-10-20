<?php

declare(strict_types=1);


namespace MyLibrary\Command;

use MyLibrary\ICommand;

interface IHandler
{
    public function Handle(ICommand $command);
}
