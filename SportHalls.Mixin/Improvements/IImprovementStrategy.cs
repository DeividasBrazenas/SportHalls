namespace SportHalls.Mixin.Improvements
{
    public interface IImprovementStrategy
    {
        double? ImprovementCost(int quality);
    }
}