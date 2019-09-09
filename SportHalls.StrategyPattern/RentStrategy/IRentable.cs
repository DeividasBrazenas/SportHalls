using System;

namespace SportHalls.StrategyPattern.RentStrategy
{
    public interface IRentable
    {
        double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}