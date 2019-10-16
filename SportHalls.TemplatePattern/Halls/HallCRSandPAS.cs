namespace SportHalls.TemplatePattern.Halls
{
    using System;
    using AdvertisementStrategies;
    using RentStrategies;

    public class HallCRSandPAS : Hall
    {
        private readonly CheapRentStrategy _rentStrategy = new CheapRentStrategy();
        private readonly PassiveAdvertisementStrategy _advertisementStrategy = new PassiveAdvertisementStrategy();

        public HallCRSandPAS(bool isIndoor) : base(isIndoor)
        {
        }

        public override double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _rentStrategy.CalculateRentCost(startDateTime, endDateTime);
        }

        public override double AdjustCost(double cost)
        {
            return _rentStrategy.AdjustCost(cost);
        }

        public override double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _advertisementStrategy.CalculateAdvertisementCost(startDateTime, endDateTime);
        }
    }
}