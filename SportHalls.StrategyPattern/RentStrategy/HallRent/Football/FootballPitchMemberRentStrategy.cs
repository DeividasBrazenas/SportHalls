using System;

namespace SportHalls.StrategyPattern.RentStrategy.HallRent.Football
{
    public class FootballPitchMemberRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour <= 19 ? rentTimeLength * 0.1 : rentTimeLength * 0.05;
        }

        public double AdjustCostForMembers(double cost)
        {
            return cost * 0.7;
        }
    }
}