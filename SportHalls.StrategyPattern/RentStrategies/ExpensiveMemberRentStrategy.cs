using System;

namespace SportHalls.StrategyPattern.RentStrategies
{
    public class ExpensiveMemberRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour < 20 ? rentTimeLength * 0.2 : rentTimeLength * 0.1;
        }

        public double AdjustCost(double cost)
        {
            return cost * 0.95;
        }
    }
}