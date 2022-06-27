using GraphLib.Interfaces;

namespace GraphLib.Base;

public class BaseCoordinate : ICoordinate
{
    protected readonly int[] _coordinateValues;

    /// <summary>
    /// Gets the value of the coordinate component in the given dimension
    /// </summary>
    /// <param name="dimension">The dimension, from 0, e.g., x: 0, y: 1, etc.</param>
    public int GetCoordinateValue(int dimension)
    {
        throw new NotImplementedException();
    }

    protected BaseCoordinate(params int[] values)
    {
        throw new NotImplementedException();
    }
}
