using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies;

namespace SportHalls.StrategyPattern
{
    public class Hall : IRentable, IAdvertisable
    {
        private readonly IRentStrategy _rentStrategy;
        private readonly IAdvertisementStrategy _advertisementStrategy;

        public Hall(IRentStrategy rentStrategy, IAdvertisementStrategy advertisementStrategy = null)
        {
            _rentStrategy = rentStrategy;
            _advertisementStrategy = advertisementStrategy ?? new NoAdvertisementStrategy();
        }

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = _rentStrategy.CalculateRentCost(startDateTime, endDateTime);

            return _rentStrategy.AdjustCostForMembers(cost);
        }

        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _advertisementStrategy.CalculateAdvertisementCost(startDateTime, endDateTime);
        }
    }
}