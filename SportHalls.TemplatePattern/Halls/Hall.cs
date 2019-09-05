using System;

namespace SportHalls.TemplatePattern.Halls
{
    public abstract class Hall
    {
        public abstract double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime);

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return CalculateSpecificHallRentCost(startDateTime, endDateTime);
        }
    }
}