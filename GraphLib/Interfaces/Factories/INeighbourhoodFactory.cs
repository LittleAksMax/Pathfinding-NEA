namespace GraphLib.Interfaces.Factories;

public interface INeighbourhoodFactory
{
    INeighbourhood CreateNeighbourhood(ICoordinate coordinate);
}
