using System;
using System.Collections.Generic;
using Parrot;

namespace Parrot.TransformPattern;

public static class TransformParrotFactory
{
    public static IParrot NorwegianBlue(double voltage, bool isNailed) => isNailed ?
            new GenericParot("Bzzzzz", new EnergizedModifier(voltage), new Nailed())
            : new GenericParot("Bzzzzz", new EnergizedModifier(voltage));

    public static IParrot European() =>
        new GenericParot("Sqoork!");

    public static IParrot African(int numberOfCoconuts) =>
        new GenericParot("Sqaark!", new CoconutCariyng(numberOfCoconuts));
}

