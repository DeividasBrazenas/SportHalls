using System;
using SportHalls.TemplatePattern.Halls.Basketball;
using SportHalls.TemplatePattern.Halls.Tennis.Members;
using Xunit;

namespace SportHalls.TemplatePattern.Tests.Advertisements
{
    public class PassiveAdvertisementUnitTests
    {
        [Theory]
        [InlineData(01, 01, 02, 01, 1240)]
        [InlineData(01, 31, 02, 27, 1080)]
        public void TennisCourtPassiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable tennisCourt = new TennisCourtForMembersPassiveAdvertisement(false);
            var cost = tennisCourt.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(01, 01, 02, 01, 1240)]
        [InlineData(01, 31, 02, 27, 1080)]
        public void BasketballHallPassiveAdvertisementTest(int startMonth, int startDay, int endMonth, int endDay, double expectedCost)
        {
            IAdvertisable basketballHall = new BasketballHallPassiveAdvertisement(false);
            var cost = basketballHall.CalculateAdvertisementCost(new DateTime(2019, startMonth, startDay, 0, 0, 00),
                new DateTime(2019, endMonth, endDay, 0, 0, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}