namespace SportHalls.StrategyPattern.Tests
{
    using System;
    using AdvertisementStrategies;
    using RentStrategies;
    using Xunit;

    public class AdvertisementUnitTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void AggressiveAdvertisementStrategy_Test(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new Hall(new CheapRentStrategy(), false, new AggressiveAdvertisementStrategy());
            var cost = tennisCourt.CalculateTotalAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 1240)]
        [InlineData(01, 31, 02, 27, 1080)]
        public void PassiveAdvertisementStrategy_Test(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new Hall(new CheapRentStrategy(), false, new PassiveAdvertisementStrategy());
            var cost = basketballHall.CalculateTotalAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void NoAdvertisementStrategy_Test(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new Hall(new CheapRentStrategy(), false);
            var cost = basketballHall.CalculateTotalAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}