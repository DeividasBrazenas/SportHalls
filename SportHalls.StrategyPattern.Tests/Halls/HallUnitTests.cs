using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies.Halls.Basketball;
using SportHalls.StrategyPattern.RentStrategies.Halls.Football;
using SportHalls.StrategyPattern.RentStrategies.Halls.Tennis;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Halls
{
    public class HallUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 24)]
        [InlineData(21, 30, 23, 00, 9)]
        public void TennisCourtRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable tennisCourt = new Hall(new TennisCourtRentStrategy());
            var cost = tennisCourt.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 12)]
        [InlineData(21, 30, 23, 00, 9)]
        public void BasketballHallRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable basketballHall = new Hall(new BasketballHallRentStrategy());
            var cost = basketballHall.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 12)]
        [InlineData(21, 30, 23, 00, 4.5)]
        public void FootballPitchRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable footballPitch = new Hall(new FootballPitchRentStrategy());
            var cost = footballPitch.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}
