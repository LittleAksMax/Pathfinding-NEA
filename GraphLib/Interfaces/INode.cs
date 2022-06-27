using GraphLib.Realizations;

namespace GraphLib.Interfaces;

public interface INode
{
    ICoordinate Coordinate { get; }
    ICost Cost { get; }
    bool IsObstacle { get; set; }
    Neighbourhood Neighbourhood { get; }
}
