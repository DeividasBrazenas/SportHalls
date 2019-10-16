namespace SportHalls.StrategyPattern.Tests
{
    using System;
    using RentStrategies;
    using Xunit;

    public class InventorUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 6)]
        [InlineData(21, 30, 23, 00, 4.5)]
        public void CheapRentStrategy_Inventor_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable item = new StrategyPattern.Inventor(new CheapRentStrategy());
            var cost = item.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 6)]
        [InlineData(21, 30, 23, 00, 4.5)]
        public void ExpensiveMemberRentStrategy_Inventor_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable item = new StrategyPattern.Inventor(new CheapRentStrategy());
            var cost = item.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}