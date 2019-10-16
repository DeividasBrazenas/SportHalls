namespace SportHalls.TemplatePattern.Halls
{
    using System;
    using AdvertisementStrategies;
    using RentStrategies;

    public class HallEMRandNAS : Hall
    {
        private readonly ExpensiveMemberRentStrategy _rentStrategy = new ExpensiveMemberRentStrategy();
        private readonly NoAdvertisementStrategy _advertisementStrategy = new NoAdvertisementStrategy();

        public HallEMRandNAS(bool isIndoor) : base(isIndoor)
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