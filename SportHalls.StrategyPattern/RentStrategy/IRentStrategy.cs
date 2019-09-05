using System;

namespace SportHalls.StrategyPattern.RentStrategy
{
    public interface IRentStrategy
    {
        double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}