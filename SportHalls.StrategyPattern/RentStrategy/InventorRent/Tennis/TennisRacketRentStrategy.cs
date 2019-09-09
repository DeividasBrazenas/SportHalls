using System;

namespace SportHalls.StrategyPattern.RentStrategy.InventorRent.Tennis
{
    public class TennisRacketRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.05;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}