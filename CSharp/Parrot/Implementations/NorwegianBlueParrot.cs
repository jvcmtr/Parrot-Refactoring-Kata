using System;

namespace Parrot.Implementations;

public class NorwegianBlueParrot : BaseParot, IParrot
{
    private readonly bool _isNailed;
    private readonly double _voltage;

    public NorwegianBlueParrot(double voltage, bool isNailed)
    {
        _isNailed = isNailed;
        _voltage = voltage;
    }

    public override double GetSpeed() => _isNailed ? 0 : Math.Min(24.0, _voltage * base.GetSpeed());

    public override string GetCry() => _voltage > 0 ? "Bzzzzzz" : "...";
}
