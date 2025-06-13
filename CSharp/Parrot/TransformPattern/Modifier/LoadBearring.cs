using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Parrot.TransformPattern;

public class LoadBearing : BaseParotModifier
{
    protected readonly double _loadFactor;
    protected readonly int _numberOfItems;

    protected virtual double totalLoad => _loadFactor * _numberOfItems;

    public LoadBearing(double loadFactor, int numberOfItems)
    {
        _loadFactor = loadFactor;
        _numberOfItems = numberOfItems;
    }

    public double Apply(double speed)
    {
        return speed - totalLoad; 
    }
}
