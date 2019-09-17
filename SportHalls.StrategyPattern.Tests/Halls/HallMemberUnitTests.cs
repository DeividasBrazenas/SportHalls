using System;
using SportHalls.StrategyPattern.HallRent.Basketball;
using SportHalls.StrategyPattern.HallRent.Football;
using SportHalls.StrategyPattern.HallRent.Tennis;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Halls
{
    public class HallMemberUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 22.8)]
        [InlineData(21, 30, 23, 00, 8.55)]
        public void TennisCourtRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable tennisCourt = new HallRent.Hall(new TennisCourtMemberRentStrategy());
            var cost = tennisCourt.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 9.6)]
        [InlineData(21, 30, 23, 00, 7.2)]
        public void BasketballHallRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable basketballHall = new HallRent.Hall(new BasketballHallMemberRentStrategy());
            var cost = basketballHall.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 8.4)]
        [InlineData(21, 30, 23, 00, 3.15)]
        public void FootballPitchRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable footballPitch = new HallRent.Hall(new FootballPitchMemberRentStrategy());
            var cost = footballPitch.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}
