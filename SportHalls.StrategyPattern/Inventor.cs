using System;
using SportHalls.StrategyPattern.RentStrategies;

namespace SportHalls.StrategyPattern
{
    public class Inventor : IRentable
    {
        private readonly IRentStrategy _rentStrategy;

        public Inventor(IRentStrategy rentStrategy)
        {
            _rentStrategy = rentStrategy;
        }

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _rentStrategy.CalculateRentCost(startDateTime, endDateTime);
        }
    }
}