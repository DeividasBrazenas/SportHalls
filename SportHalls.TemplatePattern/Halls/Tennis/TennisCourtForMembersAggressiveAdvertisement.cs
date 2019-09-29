using System;

namespace SportHalls.TemplatePattern.Halls.Tennis
{
    public class TennisCourtForMembersAggressiveAdvertisement : Hall
    {
        public TennisCourtForMembersAggressiveAdvertisement(bool isIndoor) : base(isIndoor)
        {
        }

        public override double CalculateRentCost(DateTime startDateTime, DateTime endDateTime)
        {
            var rentTimeLength = (endDateTime - startDateTime).TotalMinutes;

            return startDateTime.Hour < 20 ? rentTimeLength * 0.2 : rentTimeLength * 0.1;
        }

        public override double AdjustCost(double cost)
        {
            return cost * 0.95;
        }

        public override double CalculateAdvertisementCost(DateTime startDateTime, DateTime endDateTime)
        {
            var advertisementTimeLength = (endDateTime - startDateTime).TotalDays;

            return advertisementTimeLength * 100;
        }
    }
}