using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies.Halls.Basketball;
using SportHalls.StrategyPattern.RentStrategies.Halls.Tennis;
using SportHalls.StrategyPattern.RentStrategies.Inventor.Football;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Advertisements
{
    public class NoAdvertisementStrategyTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void TennisCourtNoAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new Hall(new TennisCourtRentStrategy());
            var cost = tennisCourt.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void BasketballHallNoAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new Hall(new BasketballHallRentStrategy());
            var cost = basketballHall.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void FootballPitchNoAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable footballPitch = new Hall(new FootballRentStrategy());
            var cost = footballPitch.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}