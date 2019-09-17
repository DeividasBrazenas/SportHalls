using System;

namespace SportHalls.StrategyPattern.RentStrategies.Inventor.Tennis
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