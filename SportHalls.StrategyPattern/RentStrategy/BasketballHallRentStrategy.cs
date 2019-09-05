using System;

namespace SportHalls.StrategyPattern.RentStrategy
{
    public class BasketballHallRentStrategy : IRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }
    }
}