using System;
using SportHalls.TemplatePattern.Halls.Basketball;
using SportHalls.TemplatePattern.Halls.Tennis;
using Xunit;

namespace SportHalls.TemplatePattern.Tests.Advertisements
{
    public class NoAdvertisementUnitTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void TennisCourtNoAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new TennisCourtNoAdvertisement(false);
            var cost = tennisCourt.CalculateTotalAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 0)]
        [InlineData(01, 31, 02, 27, 0)]
        public void BasketballHallNoAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new BasketballHallNoAdvertisement(false);
            var cost = basketballHall.CalculateTotalAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}