namespace SportHalls.Mixin.Improvements
{
    public class ImprovementStrategy : IImprovementStrategy
    {
        public double? ImprovementCost(int quality)
        {
            return quality * 5;
        }
    }
}