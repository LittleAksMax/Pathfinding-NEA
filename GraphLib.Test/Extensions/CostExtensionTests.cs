namespace GraphLib.Tests.Extensions;

public class CostExtensionTests
{
    // NOTE: no reason to test compound operators (e.g., <=, >=, !=) as they are built
    // on operators I've already implemented
    
    [Theory]
    [MemberData(nameof(EqualCostData))]
    [MemberData(nameof(UnequalCostData))]
    public void IsEqual_ShouldCheckIfCostsAreEqual((int, int, bool) data)
    {
        // Arrange
        var (cost1, cost2, expected) = data;
        // TODO: mock an ICostFactory that returns a Cost object with the given integer as in the parameter
        
        // Act
        // bool actual = cost1obj.IsEqual(cost2obj)
        
        // Assert
        // Assert.Equals(expected, actual);
    }
    
    public static IEnumerable<(int, int, bool)> EqualCostData =>
        new List<(int, int, bool)>
        {
            
        };
    
    public static IEnumerable<(int, int, bool)> UnequalCostData =>
        new List<(int, int, bool)>
        {
            
        };
}
