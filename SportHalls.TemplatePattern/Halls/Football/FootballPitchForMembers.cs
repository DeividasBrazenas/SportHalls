using System;

namespace SportHalls.TemplatePattern.Halls.Football
{
    public class FootballPitchForMembers : Hall
    {
        public override double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour <= 19 ? rentTimeLength * 0.1 : rentTimeLength * 0.05;
        }

        public override double AdjustCostForMembers(double cost)
        {
            return cost * 0.7;
        }
    }
}