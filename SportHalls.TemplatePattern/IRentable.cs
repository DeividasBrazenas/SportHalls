using System;

namespace SportHalls.TemplatePattern
{
    public interface IRentable
    {
        double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);
    }
}