<?php

declare(strict_types=1);


namespace MyLibrary\Event;

use MyLibrary\IEvent;
use MyLibrary\IPayload;

abstract class Base implements IEvent
{
    private IPayload $Payload;

    private \Datetime $Occurred;

    protected function __construct(IPayload $payload)
    {
        $this->Payload = $payload;
        $this->Occurred = new \DateTime();
    }

    public function Payload() : IPayload
    {
        return $this->Payload;
    }

    public function Occurred() : \DateTime
    {
        return $this->Occurred;
    }
}
