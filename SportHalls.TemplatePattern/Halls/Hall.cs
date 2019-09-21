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

        public abstract double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime);

        public abstract double AdjustCostForMembers(double cost);

        public abstract double CalculateSpecificHallAdvertisementCost(DateTime startDateTime, DateTime endDateTime);

        public double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var cost = CalculateSpecificHallRentCost(startDateTime, endDateTime);

            cost = _isIndoor ? cost * 1.5 : cost;

            return AdjustCostForMembers(cost);
        }

        public double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            return CalculateSpecificHallAdvertisementCost(startDateTime, endDateTime);
        }
    }
}