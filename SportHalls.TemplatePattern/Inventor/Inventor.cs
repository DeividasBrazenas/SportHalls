using System;

namespace SportHalls.TemplatePattern.Inventor
{
    public abstract class Inventor : IRentable
    {
        public abstract double CalculateSpecificItemRentCost(DateTime startDateTime, DateTime endDateTime);

        public abstract double AdjustCostForMembers(double cost);

        public double CalculateTotalRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = CalculateSpecificItemRentCost(startDateTime, endDateTime);

            return AdjustCostForMembers(cost);
        }
    }
}