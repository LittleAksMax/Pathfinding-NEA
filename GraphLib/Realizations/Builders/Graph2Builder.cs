using GraphLib.Base.Builders;
using GraphLib.Interfaces;
using GraphLib.Interfaces.Factories;

namespace GraphLib.Realizations.Builders;

public class Graph2Builder : BaseGridGraphBuilder
{
    public Graph2Builder(INodeFactory nodeFactory, ICostFactory costFactory) : base(nodeFactory, costFactory)
    {
        throw new NotImplementedException();
    }

    public override IGridGraph Build()
    {
        throw new NotImplementedException();
    }
}
