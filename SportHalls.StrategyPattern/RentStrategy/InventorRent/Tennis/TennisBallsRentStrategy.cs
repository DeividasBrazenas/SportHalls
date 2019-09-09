using System;

namespace SportHalls.StrategyPattern.RentStrategy.InventorRent.Tennis
{
    public class TennisBallsRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.04;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}