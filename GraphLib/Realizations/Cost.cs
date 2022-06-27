using GraphLib.Interfaces;
using GraphLib.Realizations.Extensions;

namespace GraphLib.Realizations;

public class Cost : ICost
{
    public int CostValue { get; }

    public Cost(int costValue)
    {
        throw new NotImplementedException();
    }

    public override int GetHashCode() => CostValue;

    public override bool Equals(object? other) => other is Cost otherCost && this.IsEqual(otherCost);

    public static bool operator <(Cost a, Cost b) => a.IsSmaller(b);
    public static bool operator >(Cost a, Cost b) => b.IsSmaller(a);
    public static bool operator ==(Cost a, Cost b) => a.IsEqual(b);
    public static bool operator !=(Cost a, Cost b) => !a.IsEqual(b);
}
