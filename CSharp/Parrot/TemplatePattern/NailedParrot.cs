using System;
using System.ComponentModel;
using Parrot.Implementations;

namespace Parrot.TemplatePattern ;

public class NailedParrot : EnergizedParot {

    private bool _isNailed;
    protected override double maximum_speed => _isNailed? 0 : base.maximum_speed ;

    public NailedParrot(double energyLevel, bool isNailed) : base(energyLevel)
    {
        _isNailed = isNailed;
    }
}

