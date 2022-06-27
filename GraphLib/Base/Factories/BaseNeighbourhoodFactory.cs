using GraphLib.Interfaces;
using GraphLib.Interfaces.Factories;

namespace GraphLib.Base.Factories;

public abstract class BaseNeighbourhoodFactory : INeighbourhoodFactory
{
    protected static readonly int[] OffsetMatrix = {-1, 0, 1};

    public abstract INeighbourhood CreateNeighbourhood(ICoordinate coordinate);
}
