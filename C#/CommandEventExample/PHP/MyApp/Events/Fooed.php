<?php

declare(strict_types=1);


namespace MyApp\Events;

use MyLibrary\Event\Base;
use MyLibrary\IPayload;

final class Fooed extends Base
{
    public function __construct(IPayload $payload)
    {
        parent::__construct($payload);
    }
}
