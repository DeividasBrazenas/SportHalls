using System;

namespace SportHalls.StrategyPattern
{
    public interface IRentable
    {
        double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}