using System;
using SportHalls.StrategyPattern.RentStrategy;
using SportHalls.StrategyPattern.RentStrategy.InventorRent.Skiing;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Inventor
{
    public class SkiingInventorUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 24)]
        [InlineData(21, 30, 23, 00, 18)]
        public void SkisRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable skis = new RentStrategy.InventorRent.Inventor(new SkisRentStrategy());
            var cost = skis.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 24)]
        [InlineData(21, 30, 23, 00, 18)]
        public void SnowboardRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable snowboard = new RentStrategy.InventorRent.Inventor(new SnowboardRentStrategy());
            var cost = snowboard.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 12)]
        [InlineData(21, 30, 23, 00, 9)]
        public void SkiingShoesRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable skiingShoes = new RentStrategy.InventorRent.Inventor(new SkiingShoesRentStrategy());
            var cost = skiingShoes.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}