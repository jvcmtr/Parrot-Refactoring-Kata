
namespace Parrot.TransformPattern;

public class CoconutCariyng : LoadBearing
{
    public const double COCONUT_LOAD_FACTOR = 9.0;
    public CoconutCariyng(int numberOfItems) : base( COCONUT_LOAD_FACTOR , numberOfItems)
    {}
}