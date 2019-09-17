using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies.Inventor.Tennis;
using Xunit;

namespace SportHalls.StrategyPattern.Tests.Inventor
{
    public class TennisInventorUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 6)]
        [InlineData(21, 30, 23, 00, 4.5)]
        public void TennisRacketRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable racket = new StrategyPattern.Inventor(new TennisRacketRentStrategy());
            var cost = racket.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 4.8)]
        [InlineData(21, 30, 23, 00, 3.6)]
        public void TennisBallsRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable balls = new StrategyPattern.Inventor(new TennisBallsRentStrategy());
            var cost = balls.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 12)]
        [InlineData(21, 30, 23, 00, 9)]
        public void TennisBallMachineRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            IRentable machine = new StrategyPattern.Inventor(new TennisBallsMachineRentStrategy());
            var cost = machine.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}