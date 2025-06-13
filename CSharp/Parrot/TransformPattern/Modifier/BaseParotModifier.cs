

namespace Parrot.TransformPattern;
public abstract class BaseParotModifier : IParotModifier
{
    public virtual string CryModifier(string cry)
    {
        return cry;
    }

    public virtual double SpeedModifier(double speed)
    {
        return speed;
    }
}