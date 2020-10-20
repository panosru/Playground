<?php
declare(strict_types=1);

use PHPUnit\Framework\TestCase;
use Roave\BetterReflection\BetterReflection;
use Roave\BetterReflection\Reflector\ClassReflector;
use Roave\BetterReflection\SourceLocator\Type\SingleFileSourceLocator;

/**
 * Class ReflectionTest
 * @testdox Test getInterfaceNames with BetterReflection and native Reflection
 * @runTestsInSeparateProcesses
 */
final class ReflectionTest extends TestCase
{
    const EXCEPTION_CLASS = 'BadException';
    const EXCEPTION_FILE = 'BadException.php';

    /**
     * @test
     * @testdox Get interfaces from a class using native reflection
     */
    public function getInterfacesFromLoadedClassNative(): void
    {
        require_once self::EXCEPTION_FILE;

        $interfaces = (new \ReflectionClass(self::EXCEPTION_CLASS))->getInterfaceNames();

        $this->assertContains(\Throwable::class, $interfaces);
    }

    /**
     * @test
     * @testdox Get interfaces from a class using better reflection
     */
    public function getInterfacesFromLoadedClassBetter(): void
    {
        require_once self::EXCEPTION_FILE;

        $interfaces = (new BetterReflection())->classReflector()->reflect(
            self::EXCEPTION_CLASS
        )->getInterfaceNames();

        $this->assertContains(\Throwable::class, $interfaces);
    }

    /**
     * @test
     * @testdox Get Interfaces from a file that has not been loaded yet using better reflection
     */
    public function getInterfacesFromUnloadedClass(): void
    {
        $astLocator = (new BetterReflection())->astLocator();
        $reflector = new ClassReflector(new SingleFileSourceLocator(
            __DIR__ .  '/../_support/' . self::EXCEPTION_FILE,
            $astLocator
        ));
        /** @var ReflectionClass $reflectionClass */
        $reflectionClass = $reflector->reflect($reflector->getAllClasses()[0]->getName());

        $this->assertContains(\Throwable::class, $reflectionClass->getInterfaceNames());
    }
}
