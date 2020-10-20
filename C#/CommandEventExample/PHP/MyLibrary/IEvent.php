<?php

declare(strict_types=1);


namespace MyLibrary;

interface IEvent
{
    public function Payload() : IPayload;
}
