using GraphLib.Interfaces;

namespace GraphLib.NullRealizations;

public class NullCoordinate : ICoordinate
{
    public int Dimensions { get; }

    public int GetCoordinateValue(int dimension)
    {
        throw new NotImplementedException();
    }
}
