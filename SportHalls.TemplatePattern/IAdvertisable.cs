using System;

namespace SportHalls.TemplatePattern
{
    public interface IAdvertisable
    {
            double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime);
    }
}