using GraphLib.Base;
using GraphLib.Interfaces;

namespace GraphLib.Realizations.Graphs;

public class Graph2 : BaseGridGraph
{
    public int Columns { get => _dimensions[0]; }
    public int Rows { get => _dimensions[1]; }
    
    protected Graph2(IReadOnlyCollection<INode> nodes, params int[] dimensions) : base(nodes)
    {
        throw new NotImplementedException();
    }
}
