namespace SportHalls.Mixin.Tests
{
    using System;
    using Expenses;
    using Improvements;
    using Rent;
    using Xunit;

    public class InventorUnitTests
    {
        [Fact]
        public void Inventor_Delegate_Fails()
        {
            var inventor = new Inventor();

            inventor.MakeSound();

            Assert.Null(inventor.CalculateExpenses(DateTime.MinValue, DateTime.MaxValue));
            Assert.Null(inventor.RentCost(DateTime.MinValue, DateTime.MaxValue));
            Assert.Null(inventor.ImprovementCost(inventor.Quality));
        }

        [Fact]
        public void Inventor_Delegate_Succeeds()
        {
            var inventor = new Inventor(new ExpensesStrategy(), new ImprovementStrategy(), new RentStrategy());

            inventor.MakeSound();

            Assert.NotNull(inventor.CalculateExpenses(DateTime.MinValue, DateTime.MaxValue));
            Assert.NotNull(inventor.RentCost(DateTime.MinValue, DateTime.MaxValue));
            Assert.NotNull(inventor.ImprovementCost(inventor.Quality));
        }
    }
}