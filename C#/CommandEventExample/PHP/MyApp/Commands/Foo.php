<?php

declare(strict_types=1);


namespace MyApp\Commands;

use MyLibrary\Command\Base;

final class Foo extends Base
{
    private string $Greeting;
    private string $Value;

    public function __construct(string $greeting)
    {
        $this->Greeting = $greeting;
        $this->Value = "World";
    }

    public function Greeting() : string
    {
        return $this->Greeting;
    }

    public function Value() : string
    {
        return $this->Value;
    }
}
