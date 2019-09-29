using System;

namespace SportHalls.TemplatePattern
{
    public interface IRentable
    {
        double CalculateTotalRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}