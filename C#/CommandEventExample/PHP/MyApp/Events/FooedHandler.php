<?php

declare(strict_types=1);


namespace MyApp\Events;

use MyLibrary\Event\Handler;
use MyLibrary\IEvent;

final class FooedHandler extends Handler
{

    public function Handle(IEvent $event): void
    {
        echo "Fooed event fired with payload: \"{$event->Payload()->Value()}\"";
    }
}
