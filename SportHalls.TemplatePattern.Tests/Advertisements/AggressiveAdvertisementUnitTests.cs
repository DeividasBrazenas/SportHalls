using System;
using SportHalls.TemplatePattern.Halls.Basketball;
using SportHalls.TemplatePattern.Halls.Tennis.RegularPeople;
using Xunit;

namespace SportHalls.TemplatePattern.Tests.Advertisements
{
    public class AggressiveAdvertisementUnitTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void TennisCourtAgressiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new TennisCourtAggressiveAdvertisement(false);
            var cost = tennisCourt.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 3100)]
        [InlineData(01, 31, 02, 27, 2700)]
        public void BasketballHallAgressiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new BasketballHallAggressiveAdvertisement(false);
            var cost = basketballHall.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}