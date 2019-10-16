namespace SportHalls.TemplatePattern.Tests
{
    using System;
    using Halls;
    using Xunit;

    public class HallUnitTests
    {
        [Theory]
        [InlineData(19, 00, 21, 00, 9, 0)]
        [InlineData(21, 30, 23, 00, 6.75, 0)]
        public void HallCRandNAS_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost, double expectedAdvertisementCost)
        {
            var hall = new HallCRSandNAS(true);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));

            var advertisementCost = hall.CalculateAdvertisementCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedAdvertisementCost, 2), Math.Round(advertisementCost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 9, 3.33)]
        [InlineData(21, 30, 23, 00, 6.75, 2.5)]
        public void HallCRandPAS_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost, double expectedAdvertisementCost)
        {
            var hall = new HallCRSandPAS(true);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));

            var advertisementCost = hall.CalculateAdvertisementCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedAdvertisementCost, 2), Math.Round(advertisementCost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 9, 8.33)]
        [InlineData(21, 30, 23, 00, 6.75, 6.25)]
        public void HallCRandAAS_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost, double expectedAdvertisementCost)
        {
            var hall = new HallCRSandAAS(true);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));

            var advertisementCost = hall.CalculateAdvertisementCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedAdvertisementCost, 2), Math.Round(advertisementCost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 34.2, 8.33)]
        [InlineData(21, 30, 23, 00, 12.82, 6.25)]
        public void HallEMRandAAS_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost, double expectedAdvertisementCost)
        {
            var hall = new HallEMRandAAS(true);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));

            var advertisementCost = hall.CalculateAdvertisementCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedAdvertisementCost, 2), Math.Round(advertisementCost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 34.2, 0)]
        [InlineData(21, 30, 23, 00, 12.82, 0)]
        public void HallEMRandNAS_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost, double expectedAdvertisementCost)
        {
            var hall = new HallEMRandNAS(true);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));

            var advertisementCost = hall.CalculateAdvertisementCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedAdvertisementCost, 2), Math.Round(advertisementCost, 2));
        }

        [Theory]
        [InlineData(19, 00, 21, 00, 34.2, 3.33)]
        [InlineData(21, 30, 23, 00, 12.82, 2.5)]
        public void HallEMRandPAS_Test(int startHours, int startMinutes, int endHours, int endMinutes, double expectedCost, double expectedAdvertisementCost)
        {
            var hall = new HallEMRandPAS(true);
            var cost = hall.CalculateTotalRentCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedCost, 2), Math.Round(cost, 2));

            var advertisementCost = hall.CalculateAdvertisementCost(new DateTime(2019, 09, 05, startHours, startMinutes, 00),
                new DateTime(2019, 09, 05, endHours, endMinutes, 00));

            Assert.Equal(Math.Round(expectedAdvertisementCost, 2), Math.Round(advertisementCost, 2));
        }
    }
}
