using System;

namespace SportHalls.TemplatePattern.Halls.Basketball
{
    public class BasketballHall : Hall
    {
        public override double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public override double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}