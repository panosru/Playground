<?php

declare(strict_types=1);

/**
 * Author: panosru
 * Date: 01/03/2018
 * Time: 17:21
 */

namespace Demo\Debug;

use Stringy\Stringy;

/**
 * Class Str
 * @package Demo\Debug
 */
final class Str extends Stringy
{

    /**
     * Check if str1 and str2 are equal
     *
     * @param string $str1
     * @param string $str2
     * @return bool
     */
    public static function equals(string $str1, string $str2): bool
    {
        return 0 === strcmp($str1, $str2);
    }
}
