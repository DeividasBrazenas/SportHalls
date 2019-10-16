using System;

namespace SportHalls.TemplatePattern.Inventor
{
    public abstract class Inventor : IRentable
    {
        public abstract double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);

        public abstract double AdjustCost(double cost);

        public double CalculateTotalRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = CalculateRentCost(startDateTime, endDateTime);

            return AdjustCost(cost);
        }
    }
}