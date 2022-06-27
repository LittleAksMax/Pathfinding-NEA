using GraphLib.Interfaces;

namespace GraphLib.Base;

public class BaseGridGraph : BaseGraph, IGridGraph
{
    protected readonly int[] _dimensions;
    
    protected BaseGridGraph(IReadOnlyCollection<INode> nodes) : base(nodes)
    {
        throw new NotImplementedException();
    }

    public int GetDimensionValue(int dimension)
    {
        throw new NotImplementedException();
    }
}
