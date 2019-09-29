using System;

namespace SportHalls.StrategyPattern
{
    public interface IRentable
    {
        double CalculateTotalRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}