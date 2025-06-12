using System;
using Parrot.Implementations;

namespace Parrot;

public static class ParotFactory
{
    // Since each implementation of IParat has a diferent contructor signature, is not practical
    // to create a single constructor wich is implementation-agnostic.

    // using multiple methods like this allow us to erase redundant variables and benefit from 
    // intelisense while keeping the implementations separate from the rest of the code. 
    public static IParrot NorwegianBlue(double voltage, bool isNailed) => new NorwegianBlueParrot(voltage, isNailed);
    public static IParrot European() => new EuropeanParot();
    public static IParrot African(int numberOfCoconuts) => new AfricanParrot(numberOfCoconuts);

    // Another possible aproach was to create a new interface IConstructableParot with a "Create" static Method
    // to garantee that each implementation of IParot would have a way to build an instance with the same set of
    // arguments. 
    // 
    // This aproach was not chosen because of the restrictions that this would impose on the implementation classes
}

