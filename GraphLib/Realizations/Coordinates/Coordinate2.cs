using GraphLib.Base;

namespace GraphLib.Realizations.Coordinates;

public class Coordinate2 : BaseCoordinate
{
    public int X { get => _coordinateValues[0]; }
    public int Y { get => _coordinateValues[1]; }

    public Coordinate2(int x, int y)
    {
        throw new NotImplementedException();
    }
}
