<?php

declare(strict_types=1);


namespace MyLibrary\Event;

use MyLibrary\IEvent;

abstract class Handler implements IHandler
{
    public abstract function Handle(IEvent $event): void;
}
