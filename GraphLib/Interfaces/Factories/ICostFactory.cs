namespace GraphLib.Interfaces.Factories;

public interface ICostFactory
{
    ICost CreateRandomCost();
    ICost CreateCost(int cost);
}
