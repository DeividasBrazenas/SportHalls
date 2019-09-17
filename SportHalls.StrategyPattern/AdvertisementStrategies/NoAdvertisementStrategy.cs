using System;

namespace SportHalls.StrategyPattern.AdvertisementStrategies
{
    public class NoAdvertisementStrategy : IAdvertisementStrategy
    {
        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return 0;
        }
    }
}