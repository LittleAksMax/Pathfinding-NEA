using GraphLib.Interfaces;
using GraphLib.Interfaces.Factories;

namespace GraphLib.Realizations.Factories;

public class NodeFactory : INodeFactory
{
    public INode CreateNode(ICoordinate coordinate, ICost cost, Neighbourhood neighbourhood)
    {
        throw new NotImplementedException();
    }
}
