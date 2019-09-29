using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies;

namespace SportHalls.StrategyPattern
{
    public class Hall : IRentable, IAdvertisable
    {
        private readonly IRentStrategy _rentStrategy;
        private readonly IAdvertisementStrategy _advertisementStrategy;
        private readonly bool _isIndoor;

        public Hall(IRentStrategy rentStrategy, bool isIndoor, IAdvertisementStrategy advertisementStrategy = null)
        {
            _rentStrategy = rentStrategy;
            _isIndoor = isIndoor;
            _advertisementStrategy = advertisementStrategy ?? new NoAdvertisementStrategy();
        }

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = _rentStrategy.CalculateRentCost(startDateTime, endDateTime);

            cost = _isIndoor ? cost * 1.5 : cost;

            return _rentStrategy.AdjustCost(cost);
        }

        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _advertisementStrategy.CalculateAdvertisementCost(startDateTime, endDateTime);
        }
    }
}