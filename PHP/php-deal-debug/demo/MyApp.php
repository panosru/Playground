<?php
declare(strict_types=1);

namespace Demo;

use PhpDeal\Annotation as Contract;
use PhpDeal\ContractApplication;

class MyApp
{
    /**
     * @return void
     */
    final public function run(): void
    {
      ContractApplication::getInstance()->init([
          'debug' => true,
          'appDir' => __DIR__ ,
          'cacheDir' => __DIR__ . '/../cache',
      ]);
    }

    /**
     * Just a number
     *
     * @param int $num
     *
     * @return void
     *
     * @Contract\Verify("$num>10 && is_numeric($num)")
     */
    public function test(int $num): void
    {
      echo $num;
    }
}
