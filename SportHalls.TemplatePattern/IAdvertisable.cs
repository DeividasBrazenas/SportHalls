using System;

namespace SportHalls.TemplatePattern
{
    public interface IAdvertisable
    {
            double CalculateTotalAdvertisementCost(DateTime startDateTime, DateTime endDateTime);
    }
}