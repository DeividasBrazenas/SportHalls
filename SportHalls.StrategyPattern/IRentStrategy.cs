using System;

namespace SportHalls.StrategyPattern
{
    public interface IRentStrategy
    {
        double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);

        double AdjustCostForMembers(double cost);
    }
}