using System;
using System.Collections.Generic;

namespace Parrot.Implementations;

public class AfricanParrot : BaseParot, IParrot
{
    private readonly int _numberOfCoconuts;

    public AfricanParrot(int numberOfCoconuts) :base()
    {
        _numberOfCoconuts = numberOfCoconuts;
    }

    public override string GetCry() => "Sqaark!";

    public override double GetSpeed() => Math.Max(0, base.GetSpeed() - GetLoadFactor() * _numberOfCoconuts);

    private double GetLoadFactor() => 9.0;
}
