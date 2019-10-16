namespace SportHalls.TemplatePattern.RentStrategies
{
    using System;

    public class ExpensiveMemberRentStrategy
    {
        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour < 20 ? rentTimeLength * 0.2 : rentTimeLength * 0.1;
        }

        public double AdjustCost(double cost)
        {
            return cost * 0.95;
        }
    }
}