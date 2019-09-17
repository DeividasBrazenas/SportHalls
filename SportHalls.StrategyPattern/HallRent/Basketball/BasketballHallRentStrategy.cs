using System;

namespace SportHalls.StrategyPattern.HallRent.Basketball
{
    public class BasketballHallRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}