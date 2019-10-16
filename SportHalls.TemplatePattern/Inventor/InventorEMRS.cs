namespace SportHalls.TemplatePattern.Inventor
{
    using System;
    using RentStrategies;

    public class InventorEMRS : Inventor
    {
        private readonly ExpensiveMemberRentStrategy _rentStrategy = new ExpensiveMemberRentStrategy();

        public override double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _rentStrategy.CalculateRentCost(startDateTime, endDateTime);
        }

        public override double AdjustCost(double cost)
        {
            return _rentStrategy.AdjustCost(cost);
        }
    }
}