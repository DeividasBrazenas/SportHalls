namespace SportHalls.Mixin.Tests
{
    using System;
    using Expenses;
    using Improvements;
    using Rent;
    using Xunit;

    public class HallUnitTests
    {
        [Fact]
        public void Hall_Delegate_Fails()
        {
            var hall = new Hall();

            hall.Entertain();

            Assert.Null(hall.CalculateExpenses(DateTime.MinValue, DateTime.MaxValue));
            Assert.Null(hall.RentCost(DateTime.MinValue, DateTime.MaxValue));
            Assert.Null(hall.ImprovementCost(hall.Quality));
        }

        [Fact]
        public void Hall_Delegate_Succeeds()
        {
            var hall = new Hall(new ExpensesStrategy(), new ImprovementStrategy(), new RentStrategy());

            hall.Entertain();

            Assert.NotNull(hall.CalculateExpenses(DateTime.MinValue, DateTime.MaxValue));
            Assert.NotNull(hall.RentCost(DateTime.MinValue, DateTime.MaxValue));
            Assert.NotNull(hall.ImprovementCost(hall.Quality));
        }
    }
}