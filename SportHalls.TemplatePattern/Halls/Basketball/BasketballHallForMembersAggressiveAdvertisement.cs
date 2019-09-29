using System;

namespace SportHalls.TemplatePattern.Halls.Basketball
{
    public class BasketballHallForMembersAggressiveAdvertisement : Hall
    {
        public BasketballHallForMembersAggressiveAdvertisement(bool isIndoor) : base(isIndoor)
        {
        }

        public override double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public override double AdjustCost(double cost)
        {
            return cost * 0.8;
        }

        public override double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 100;
        }
    }
}