using System;

namespace SportHalls.StrategyPattern.AdvertisementStrategies
{
    public class SemiAggressiveAdvertisementStrategy : IAdvertisementStrategy
    {
        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 70;
        }
    }
}