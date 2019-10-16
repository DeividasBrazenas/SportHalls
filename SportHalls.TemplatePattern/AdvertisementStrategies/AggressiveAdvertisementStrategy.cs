namespace SportHalls.TemplatePattern.AdvertisementStrategies
{
    using System;

    public class AggressiveAdvertisementStrategy
    {
        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 100;
        }
    }
}