using System;
using SportHalls.StrategyPattern;
using SportHalls.StrategyPattern.RentStrategy;
using Xunit;

namespace SportHalls.StratgyPattern.Tests
{
    public class HallsUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 24)]
        [InlineData(21, 30, 23, 00, 9)]
        public void TennisCourtRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var tennisCourt = new Hall(new TennisCourtRentStrategy());
            var cost = tennisCourt.CalculateHallRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(expectedCost, cost);
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 12)]
        [InlineData(21, 30, 23, 00, 9)]
        public void BasketballHallRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var basketballHall = new Hall(new BasketballHallRentStrategy());
            var cost = basketballHall.CalculateHallRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(expectedCost, cost);
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 12)]
        [InlineData(21, 30, 23, 00, 4.5)]
        public void FootballPitchRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var footballPitch = new Hall(new FootballPitchRentStrategy());
            var cost = footballPitch.CalculateHallRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(expectedCost, cost);
        }
    }
}
