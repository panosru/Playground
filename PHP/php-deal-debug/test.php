<?php
declare(strict_types=1);

/**
 * Author: panosru
 * Date: 2019-01-06
 * Time: 15:41
 */

require_once __DIR__ . '/vendor/autoload.php';

use PhpDeal\ContractApplication;

ContractApplication::getInstance()->init([
    'debug' => true,
    'appDir' => __DIR__ . '/demo',
    'cacheDir' => __DIR__ . '/cache',
]);


$account = new Demo\Account();
$account->deposit(0);
echo $account->getBalance();
