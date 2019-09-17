using System;

namespace SportHalls.StrategyPattern.AdvertisementStrategies
{
    public interface IAdvertisementStrategy
    {
        double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime);
    }
}