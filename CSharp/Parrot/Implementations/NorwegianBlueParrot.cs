using System;
using System.Reflection.Metadata;

namespace Parrot.Implementations;

public class NorwegianBlueParrot : BaseParot, IParrot
{
    private readonly bool _isNailed;
    private readonly double _voltage;
    private double _maxSpeed => _isNailed? 0 : 24.0;

    public NorwegianBlueParrot(double voltage, bool isNailed)
    {
        _isNailed = isNailed;
        _voltage = voltage;
    }

    public override string GetCry() => _voltage > 0 ? "Bzzzzzz" : "...";

    public override double GetSpeed() => Math.Min(_maxSpeed, _voltage * base.GetSpeed());

    private double _desiredSpeed => _voltage * base.GetSpeed();
}
