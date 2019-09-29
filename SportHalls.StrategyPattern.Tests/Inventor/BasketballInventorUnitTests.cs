using System;
using SportHalls.StrategyPattern.RentStrategies;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Inventor
{
    public class BasketballInventorUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 6)]
        [InlineData(21, 30, 23, 00, 4.5)]
        public void BasketballRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable basketball = new StrategyPattern.Inventor(new VeryCheapRentStrategy());
            var cost = basketball.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}