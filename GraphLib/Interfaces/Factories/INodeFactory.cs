using GraphLib.Realizations;

namespace GraphLib.Interfaces.Factories;

public interface INodeFactory
{
    INode CreateNode(ICoordinate coordinate, ICost cost, Neighbourhood neighbourhood);
}
