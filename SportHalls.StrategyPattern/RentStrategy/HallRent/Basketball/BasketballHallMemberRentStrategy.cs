using System;

namespace SportHalls.StrategyPattern.RentStrategy.HallRent.Basketball
{
    public class BasketballHallMemberRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost * 0.8;
        }
    }
}