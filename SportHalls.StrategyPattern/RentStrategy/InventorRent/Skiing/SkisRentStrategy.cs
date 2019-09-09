using System;

namespace SportHalls.StrategyPattern.RentStrategy.InventorRent.Skiing
{
    public class SkisRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.2;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}