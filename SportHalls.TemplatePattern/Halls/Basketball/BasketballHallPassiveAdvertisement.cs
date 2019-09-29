using System;

namespace SportHalls.TemplatePattern.Halls.Basketball
{
    public class BasketballHallPassiveAdvertisement : Hall
    {
        public BasketballHallPassiveAdvertisement(bool isIndoor) : base(isIndoor)
        {
        }

        public override double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return rentTimeLength * 0.1;
        }

        public override double AdjustCost(double cost)
        {
            return cost;
        }

        public override double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 40;
        }
    }
}