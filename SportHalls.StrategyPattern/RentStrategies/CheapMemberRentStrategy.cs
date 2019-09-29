using System;

namespace SportHalls.StrategyPattern.RentStrategies
{
    public class CheapMemberRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public double AdjustCost(double cost)
        {
            return cost * 0.8;
        }
    }
}