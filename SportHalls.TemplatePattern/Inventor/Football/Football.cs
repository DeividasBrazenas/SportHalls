using System;

namespace SportHalls.TemplatePattern.Inventor.Football
{
    public class Football : Inventor
    {
        public override double CalculateSpecificItemRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.03;
        }

        public override double AdjustCostForMembers(double cost)
        {
            return cost;
        }
    }
}