using System;

namespace SportHalls.TemplatePattern.Halls
{
    public abstract class Hall : IRentable, IAdvertisable
    {
        private readonly bool _isIndoor;

        protected Hall(bool isIndoor)
        {
            _isIndoor = isIndoor;
        }

        public abstract double CalculateRentCost(DateTime startDateTime, DateTime endDateTime);

        public abstract double AdjustCost(double cost);

        public abstract double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime);

        public double CalculateTotalRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = CalculateRentCost(startDateTime, endDateTime);

            cost = _isIndoor ? cost * 1.5 : cost;

            return AdjustCost(cost);
        }

        public double CalculateTotalAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return CalculateAdvertisementCost(startDateTime, endDateTime);
        }
    }
}