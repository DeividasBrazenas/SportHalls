namespace SportHalls.TemplatePattern.Inventor
{
    using System;
    using RentStrategies;

    public class InventorCRS : Inventor
    {
        private readonly CheapRentStrategy _rentStrategy = new CheapRentStrategy();

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