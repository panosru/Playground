<?php

declare(strict_types=1);


namespace MyLibrary\Event;

use MyLibrary\IEvent;

interface IHandler
{
    public function Handle(IEvent $event) : void;
}
