using System;

namespace SportHalls.TemplatePattern.Halls
{
    public class FootballPitch : Hall
    {
        public override double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour <= 19 ? rentTimeLength * 0.1 : rentTimeLength * 0.05;
        }
    }
}