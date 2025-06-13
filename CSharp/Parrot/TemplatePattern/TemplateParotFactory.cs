using System;
using Parrot;

namespace Parrot.TemplatePattern;

public static class TemplateParrotFactory
{
    public static IParrot NorwegianBlue(double voltage, bool isNailed) => new NailedParrot(voltage, isNailed);
    public static IParrot European() => new GenericParot("Sqoork!");
    public static IParrot African(int numberOfCoconuts) => new LoadBearerParot( "Sqaark!", numberOfCoconuts, 9.0 );
}

