using System;
using System.Globalization;

namespace Parrot.TemplatePattern;

public class LoadBearerParot : GenericParot{
    private double _loadFactor;

    protected override double desiredSpeed => base.desiredSpeed - _loadFactor;

    public LoadBearerParot(string cry, int numberOfItems, double itemLoadFactor):base(cry)
    {
        _loadFactor = itemLoadFactor * numberOfItems;
    }
}

