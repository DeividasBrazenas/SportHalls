using System;
using SportHalls.TemplatePattern.Halls.Basketball;
using SportHalls.TemplatePattern.Halls.Tennis;
using Xunit;

namespace SportHalls.TemplatePattern.Tests.Halls
{
    public class HallMemberUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 22.8)]
        [InlineData(21, 30, 23, 00, 8.55)]
        public void TennisCourtForMembersRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var tennisCourt = new TennisCourtForMembersAggressiveAdvertisement(false);
            var cost = tennisCourt.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 14.4)]
        [InlineData(21, 30, 23, 00, 10.8)]
        public void BasketballHallForMembersRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var basketballHall = new BasketballHallForMembersAggressiveAdvertisement(true);
            var cost = basketballHall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}