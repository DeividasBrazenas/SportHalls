using System;

namespace SportHalls.StrategyPattern.RentStrategy.InventorRent.Basketball
{
    public class BasketballRentStrategy : IRentStrategy
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