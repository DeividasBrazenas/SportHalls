using System;

namespace SportHalls.StrategyPattern.HallRent
{
    public class Hall : IRentable
    {
        private readonly IRentStrategy _rentStrategy;

        public Hall(IRentStrategy rentStrategy)
        {
            _rentStrategy = rentStrategy;
        }

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = _rentStrategy.CalculateRentCost(startDateTime, endDateTime);

            return _rentStrategy.AdjustCostForMembers(cost);
        }
    }
}