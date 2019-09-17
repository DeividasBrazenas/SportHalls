using System;

namespace SportHalls.TemplatePattern.Halls
{
    public abstract class Hall
    {
        public abstract double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime);

        public abstract double AdjustCostForMembers(double cost);

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = CalculateSpecificHallRentCost(startDateTime, endDateTime);

            return AdjustCostForMembers(cost);
        }

    }
}