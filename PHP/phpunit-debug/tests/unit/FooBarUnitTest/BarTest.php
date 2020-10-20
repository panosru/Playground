<?php

declare(strict_types=1);

/**
 * Author: panosru
 * Date: 2019-01-21
 * Time: 13:08
 */

namespace FooBarUnitTest;

use Foo\Bar;
use PHPUnit\Framework\TestCase;

/**
 * Class BarTest
 * @package FooBarUnitTest
 * @coversDefaultClass \Foo\Bar
 */
final class BarTest extends TestCase
{
    /** @var Bar */
    private $bar;

    /**
     * @test
     * @covers ::foobar
     * @throws \Exception
     */
    public function foobarWithValidValue(): void
    {
        $this->assertSame('foo', $this->bar->foobar('foo'));
    }

    /**
     * @test
     * @covers ::foobar
     * @expectedException \Exception
     * @expectedExceptionMessage 'foobar' is not allowed here.
     * @runInSeparateProcess
     * @throws \Exception
     */
    public function foobarWithInvalidValue(): void
    {
        $this->bar->foobar('foobar');
    }

    /**
     * @before
     */
    public function setupBar(): void
    {
        $this->bar = new Bar();
    }
}
