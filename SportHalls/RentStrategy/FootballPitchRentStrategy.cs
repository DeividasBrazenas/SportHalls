using System;

namespace SportHalls.StrategyPattern.RentStrategy
{
    public class FootballPitchRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour <= 19 ? rentTimeLength * 0.1 : rentTimeLength * 0.05;
        }
    }
}