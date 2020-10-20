<?php
declare(strict_types=1);

/**
 * Author: panosru
 * Date: 2019-02-19
 * Time: 16:41
 */

require_once __DIR__ . '/vendor/autoload.php';

$app = new \Demo\MyApp();
$app->run();

$app->test(5);
