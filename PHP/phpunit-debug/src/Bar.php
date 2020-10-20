<?php

declare(strict_types=1);

/**
 * Author: panosru
 * Date: 2019-01-21
 * Time: 13:02
 */

namespace Foo;

/**
 * Class Bar
 * @package Foo
 */
class Bar
{
    private const ALLOWED = ['foo','bar'];

    /**
     * @param string $value
     * @return string
     * @throws \Exception
     */
    public function foobar(string $value): string
    {
        if (!\in_array($value, self::ALLOWED, true)) {
            throw new \Exception("'{$value}' is not allowed here.");
        }

        return $value;
    }
}
