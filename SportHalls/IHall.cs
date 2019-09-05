using System;

namespace SportHalls.StrategyPattern
{
    public interface IHall
    {
        double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}