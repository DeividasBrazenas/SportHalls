using System;
using SportHalls.StrategyPattern.RentStrategy;

namespace SportHalls.StrategyPattern
{
    public class Hall
    {
        private readonly IRentStrategy _rentStrategy;

        public Hall(IRentStrategy rentStrategy)
        {
            _rentStrategy = rentStrategy;
        }

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _rentStrategy.CalculateRentCost(startDateTime, endDateTime);
        }
    }
}