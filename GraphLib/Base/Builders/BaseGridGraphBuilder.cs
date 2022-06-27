using GraphLib.Enums;
using GraphLib.Interfaces;
using GraphLib.Interfaces.Builders;
using GraphLib.Interfaces.Factories;

namespace GraphLib.Base.Builders;

public abstract class BaseGridGraphBuilder : IGridGraphBuilder
{
    protected bool weighted;
    protected GraphWeighting weighting;
    protected ICoordinate start;
    protected ICoordinate end;
    protected int[] dimensions;
    protected INodeFactory nodeFactory;
    protected ICostFactory costFactory;

    protected BaseGridGraphBuilder(INodeFactory nodeFactory, ICostFactory costFactory)
    {
        throw new NotImplementedException();
    }
    
    private void Dimensions(params int[] dimensions)
    {
        throw new NotImplementedException();
    }

    public BaseGridGraphBuilder Start(ICoordinate start)
    {
        throw new NotImplementedException();
    }
    
    public BaseGridGraphBuilder End(ICoordinate end)
    {
        throw new NotImplementedException();
    }

    public BaseGridGraphBuilder Weighted(bool weighted = true)
    {
        throw new NotImplementedException();
    }

    public BaseGridGraphBuilder Weighting(GraphWeighting weighting)
    {
        throw new NotImplementedException();
    }

    public abstract IGridGraph Build();
}
