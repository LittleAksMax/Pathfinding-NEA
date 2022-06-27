namespace GraphLib.Interfaces;

public interface IGraph
{
    ICoordinate Start { get; set; }
    ICoordinate End { get; set; }
    
    public INode GetNodeAtCoordinate(ICoordinate coordinate);
}
