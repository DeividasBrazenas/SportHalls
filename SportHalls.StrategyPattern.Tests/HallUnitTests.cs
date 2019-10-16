namespace SportHalls.StrategyPattern.Tests
{
    using System;
    using RentStrategies;
    using Xunit;

    public class HallUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 9)]
        [InlineData(21, 30, 23, 00, 6.75)]
        public void CheapRentStrategy_Hall_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable hall = new Hall(new CheapRentStrategy(), true);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 22.8)]
        [InlineData(21, 30, 23, 00, 8.55)]
        public void ExpensiveMemberRentStrategy_Hall_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable hall = new Hall(new ExpensiveMemberRentStrategy(), false);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}
