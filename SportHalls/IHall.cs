using System;

namespace SportHalls.StrategyPattern
{
    public interface IHall
    {
        double CalculateHallRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}