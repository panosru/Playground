<?php
declare(strict_types=1);

use MyApp\Commands\Foo;
use MyApp\Commands\FooHandler;

// Generate autoload by running $ composer dump-autoload --no-plugins
require_once __DIR__ . '/vendor/autoload.php';

(new FooHandler())
    ->Handle(new Foo("Hello"));
