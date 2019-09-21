using System;

namespace SportHalls.TemplatePattern.Halls.Basketball
{
    public class BasketballHallForMembersPassiveAdvertisement : Hall
    {
        public BasketballHallForMembersPassiveAdvertisement(bool isIndoor) : base(isIndoor)
        {
        }

        public override double CalculateSpecificHallRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public override double AdjustCostForMembers(double cost)
        {
            return cost * 0.8;
        }

        public override double CalculateSpecificHallAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 40;
        }
    }
}