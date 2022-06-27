using GraphLib.Interfaces;

namespace GraphLib.Realizations;

public class Neighbourhood : INeighbourhood
{
    public IReadOnlyCollection<INode> Neighbours { get; }

    public Neighbourhood(IReadOnlyCollection<INode> neighbours)
    {
        throw new NotImplementedException();
    }
}
