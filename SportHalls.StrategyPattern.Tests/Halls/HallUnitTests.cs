using System;
using SportHalls.StrategyPattern.RentStrategies;
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
            IRentable tennisCourt = new Hall(new ExpensiveRentStrategy(), false);
            var cost = tennisCourt.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 18)]
        [InlineData(21, 30, 23, 00, 13.5)]
        public void BasketballHallRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable basketballHall = new Hall(new CheapRentStrategy(), true);
            var cost = basketballHall.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}
