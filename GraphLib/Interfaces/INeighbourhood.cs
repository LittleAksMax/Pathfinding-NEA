namespace GraphLib.Interfaces;

public interface INeighbourhood
{
    IReadOnlyCollection<INode> Neighbours { get; }
}
