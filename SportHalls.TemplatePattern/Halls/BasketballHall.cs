using System;

namespace SportHalls.TemplatePattern.Halls
{
    public class BasketballHall : Hall
    {
        public override double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }
    }
}