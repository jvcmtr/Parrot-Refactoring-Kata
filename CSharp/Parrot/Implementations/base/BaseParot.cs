using System;
using System.Security.Cryptography;

namespace Parrot.Implementations;

public abstract class BaseParot : IParrot
{
    public abstract string GetCry(); 
    public virtual double GetSpeed() => 12.0;
}

