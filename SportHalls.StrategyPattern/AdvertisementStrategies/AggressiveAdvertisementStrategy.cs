using System;

namespace SportHalls.StrategyPattern.AdvertisementStrategies
{
    public class AggressiveAdvertisementStrategy : IAdvertisementStrategy
    {
        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 100;
        }
    }
}