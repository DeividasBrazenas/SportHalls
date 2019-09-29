using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Advertisements
{
    public class AggressiveAdvertisementUnitTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void TennisCourtAgressiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new Hall(new ExpensiveRentStrategy(), false, new AggressiveAdvertisementStrategy());
            var cost = tennisCourt.CalculateTotalAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void BasketballHallAgressiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new Hall(new CheapRentStrategy(), false, new AggressiveAdvertisementStrategy());
            var cost = basketballHall.CalculateTotalAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}