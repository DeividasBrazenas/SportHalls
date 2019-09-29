using System;
using SportHalls.StrategyPattern.RentStrategies;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Advertisements
{
    public class NoAdvertisementUnitTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void TennisCourtNoAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new Hall(new ExpensiveRentStrategy(), false);
            var cost = tennisCourt.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void BasketballHallNoAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new Hall(new CheapRentStrategy(), false);
            var cost = basketballHall.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}