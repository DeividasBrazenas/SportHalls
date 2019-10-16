namespace SportHalls.TemplatePattern.RentStrategies
{
    using System;

    public class CheapRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.05;
        }

        public double AdjustCost(double cost)
        {
            return cost;
        }
    }
}