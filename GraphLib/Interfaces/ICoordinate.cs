namespace GraphLib.Interfaces;

public interface ICoordinate
{
    int Dimensions { get; }
    
    int GetCoordinateValue(int dimension);
}
