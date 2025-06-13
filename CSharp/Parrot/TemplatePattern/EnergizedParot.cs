using System;
using System.ComponentModel;
using Parrot.Implementations;

namespace Parrot.TemplatePattern ;

public class EnergizedParot : GenericParot {

    private double voltage;
    protected override double desiredSpeed => base.desiredSpeed * voltage;
    public override string GetCry() {
        return voltage > 0 ? "Bzzzzzz" : "..."; 
    }

    public EnergizedParot(double energyLevel) : base("")
    {
        voltage = energyLevel;
    }
}

