namespace SportHalls.TemplatePattern.AdvertisementStrategies
{
    using System;

    public class NoAdvertisementStrategy
    {
        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return 0;
        }
    }
}