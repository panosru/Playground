<?php

declare(strict_types=1);

namespace MyApp\Payloads;

use MyLibrary\IPayload;

final class Foo implements IPayload
{
    private string $Value;

    public function __construct(string $value)
    {
        $this->Value = $value;
    }

    public function Value() : string
    {
        return $this->Value;
    }
}
