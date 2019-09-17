using System;

namespace SportHalls.StrategyPattern
{
    public interface IAdvertisable
    {
        double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime);
    }
}