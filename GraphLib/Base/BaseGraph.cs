using GraphLib.Interfaces;
using GraphLib.NullRealizations;

namespace GraphLib.Base;

public class BaseGraph : IGraph
{
    private readonly IDictionary<ICoordinate, INode> _nodes;

    public ICoordinate Start { get; set; } = new NullCoordinate();
    public ICoordinate End { get; set; } = new NullCoordinate();

    public INode GetNodeAtCoordinate(ICoordinate coordinate)
    {
        throw new NotImplementedException();
    }

    protected BaseGraph(IReadOnlyCollection<INode> nodes)
    {
        throw new NotImplementedException();
    }
}
