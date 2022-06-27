using GraphLib.Interfaces;
using GraphLib.Interfaces.Factories;

namespace GraphLib.Realizations.Extensions;

public static class GraphExtensions
{
    public static void Smooth(this IGraph self, ICostFactory costFactory, IMeanCostCalculator meanCostCalculator, int smoothLevel)
    {
          
    }

    public static bool IsNodeWithinGraph(this IGraph self, INode node)
    {
        throw new NotImplementedException();
    }
}
