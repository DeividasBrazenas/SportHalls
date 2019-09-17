using System;

namespace SportHalls.StrategyPattern.AdvertisementStrategies
{
    public class PassiveAdvertisementStrategy : IAdvertisementStrategy
    {
        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 40;
        }
    }
}