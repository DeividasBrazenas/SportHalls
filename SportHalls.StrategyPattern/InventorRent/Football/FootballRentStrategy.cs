using System;

namespace SportHalls.StrategyPattern.InventorRent.Football
{
    public class FootballRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.03;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}