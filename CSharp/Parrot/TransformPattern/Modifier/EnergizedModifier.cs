using System;
using System.Collections.Generic;

namespace Parrot.TransformPattern;

public class EnergizedModifier : BaseParotModifier
{
    protected double _voltage;
    public EnergizedModifier(double voltage)
    {
        _voltage = voltage;
    }

    public override double SpeedModifier(double speed)
    {
        return speed * _voltage;
    }

    public override string CryModifier(string cry)
    {
        return _voltage > 0 ? cry : "..."; 
    }
}
