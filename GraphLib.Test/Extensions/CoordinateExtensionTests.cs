using GraphLib.Interfaces;
using GraphLib.Realizations.Coordinates;
using GraphLib.Realizations.Extensions;

namespace GraphLib.Tests.Extensions;

public class CoordinateExtensionTests
{
    [Theory]
    [MemberData(nameof(DifferentDimensionTestData))]
    public void IsEqual_ShouldReturnFalseIfDifferentDimensions((ICoordinate, ICoordinate) data)
    {
        // Arrange
        var (self, coordinate) = data;
        
        // Act
        bool actual = self.IsEqual(coordinate);

        // Assert
        Assert.False(actual);
    }

    [Theory]
    [MemberData(nameof(EqualComponentTestData))]
    public void IsEqual_ShouldReturnTrueSinceComponentsAreEqual((ICoordinate, ICoordinate) data)
    {
        // Arrange
        var (self, coordinate) = data;
        bool expected = true;

        // Act
        bool actual = self.IsEqual(coordinate);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(UnequalComponentTestData))]
    public void IsEqual_ShouldReturnFalseSinceComponentsAreUnequal((ICoordinate, ICoordinate) data)
    {
        // Arrange
        var (self, coordinate) = data;
        bool expected = false;
        
        // Act
        bool actual = self.IsEqual(coordinate);

        // Assert
        Assert.Equal(expected, actual);
    }
    
    public static IEnumerable<(ICoordinate, ICoordinate)> DifferentDimensionTestData =>
        new List<(ICoordinate, ICoordinate)>
        {
            // TODO: look into mocking and see how you can do this
        };
    
    public static IEnumerable<(ICoordinate, ICoordinate)> EqualComponentTestData =>
        new List<(ICoordinate, ICoordinate)>
        {
            (new Coordinate2(2, 5), new Coordinate2(2, 5)),
            (new Coordinate2(-6, -3), new Coordinate2(-6, -3)),
            (new Coordinate2(int.MaxValue, 0), new Coordinate2(int.MaxValue, 0)),
            (new Coordinate2(int.MaxValue, int.MinValue), new Coordinate2(int.MaxValue, int.MinValue))
        };
    
    public static IEnumerable<(ICoordinate, ICoordinate)> UnequalComponentTestData =>
        new List<(ICoordinate, ICoordinate)>
        {
            (new Coordinate2(2, 5), new Coordinate2(3, 5)),
            (new Coordinate2(-6, -3), new Coordinate2(-6, 3)),
            (new Coordinate2(int.MaxValue, 0), new Coordinate2(0, int.MaxValue)),
            (new Coordinate2(int.MinValue, int.MinValue), new Coordinate2(int.MaxValue, int.MinValue))
        };
}
