using System;

namespace SportHalls.StrategyPattern
{
    public interface IAdvertisable
    {
        double CalculateTotalAdvertisementCost(DateTime startDateTime, DateTime endDateTime);
    }
}