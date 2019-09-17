using System;
using SportHalls.TemplatePattern.Halls.Basketball;
using SportHalls.TemplatePattern.Halls.Football;
using SportHalls.TemplatePattern.Halls.Tennis;
using Xunit;

namespace SportHalls.TemplatePattern.Tests.Halls
{
    public class HallForMembersUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 22.8)]
        [InlineData(21, 30, 23, 00, 8.55)]
        public void TennisCourtForMembersRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var tennisCourt = new TennisCourtForMembers();
            var cost = tennisCourt.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 9.6)]
        [InlineData(21, 30, 23, 00, 7.2)]
        public void BasketballHallForMembersRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var basketballHall = new BasketballHallForMembers();
            var cost = basketballHall.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 8.4)]
        [InlineData(21, 30, 23, 00, 3.15)]
        public void FootballPitchForMembersRentTest(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost)
        {
            var footballPitch = new FootballPitchForMembers();
            var cost = footballPitch.CalculateRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));
        }
    }
}