using System;

namespace SportHalls.StrategyPattern.RentStrategies.Halls.Tennis
{
    public class TennisCourtRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour < 20 ? rentTimeLength * 0.2 : rentTimeLength * 0.1;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}