using System;

namespace SportHalls.StrategyPattern.RentStrategies
{
    public interface IRentStrategy
    {
        double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);

        double AdjustCostForMembers(double cost);
    }
}