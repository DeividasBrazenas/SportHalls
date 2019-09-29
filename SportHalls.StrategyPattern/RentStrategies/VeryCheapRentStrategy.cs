using System;

namespace SportHalls.StrategyPattern.RentStrategies
{
    public class VeryCheapRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.05;
        }

        public double AdjustCost(double cost)
        {
            return cost;
        }
    }
}