using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Parrot.TransformPattern;

public class GenericParot : IParrot
{
    protected const double BASE_SPEED = 12.0;
    protected const double MIN_SPEED = 0;
    protected const double MAX_SPEED = 24.0;

    protected virtual double desiredSpeed => _modifiers.Aggregate( BASE_SPEED, (val, mod) => mod.SpeedModifier(val));

    protected IList<IParotModifier> _modifiers = new List<IParotModifier>() ;
    protected string _cry;

    public GenericParot(string cry, params IParotModifier[] modifiers)
    {
        _cry = cry;
        _modifiers = new List<IParotModifier>(modifiers);
    }

    public virtual string GetCry() => _modifiers.Aggregate( _cry, (val, mod) => mod.CryModifier(val));

    public virtual double GetSpeed() => Math.Clamp(desiredSpeed, MIN_SPEED, MAX_SPEED);
}

