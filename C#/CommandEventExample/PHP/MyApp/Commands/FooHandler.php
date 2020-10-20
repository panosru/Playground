<?php

declare(strict_types=1);


namespace MyApp\Commands;

use MyApp\Events\Fooed;
use MyApp\Events\FooedHandler;
use MyLibrary\Command\Handler;
use MyLibrary\ICommand;

final class FooHandler extends Handler
{

    public function Handle(ICommand $command)
    {
        // Some logic
        echo "Foo command handled\n";

        $result = "{$command->Greeting()}, {$command->Value()}";

        // Obviously we will have an even emiter that will fire the event in real world
        (new FooedHandler())
            ->Handle(new Fooed(new \MyApp\Payloads\Foo($result)));

        return $result;
    }
}
