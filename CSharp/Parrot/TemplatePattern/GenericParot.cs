using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Parrot.TemplatePattern;

public class GenericParot : IParrot
{
    protected virtual double desiredSpeed => 12.0;
    protected virtual double minimum_speed => 0;
    protected virtual double maximum_speed => double.MaxValue;
    protected string _cry;

    public GenericParot(string cry)
    {
        _cry = cry;
    }

    public virtual string GetCry() => _cry;
    public virtual double GetSpeed() => Math.Clamp(desiredSpeed, minimum_speed, maximum_speed);
}

