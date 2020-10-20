<?php

namespace TestDemoDebug;

use Demo\Debug\Str;

class StrTest extends \Codeception\Test\Unit
{

    public function testStringy()
    {
        $obj = Str::create('foo');
        self::assertInstanceOf(\Stringy\Stringy::class, $obj);
    }

    public function testEquals()
    {
        self::assertTrue(Str::equals('foo', 'foo'));
    }
}
