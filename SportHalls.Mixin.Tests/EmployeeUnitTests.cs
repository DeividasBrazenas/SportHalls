using System;
using Xunit;

namespace SportHalls.Mixin.Tests
{
    using Expenses;
    using Rent;

    public class EmployeeUnitTests
    {
        [Fact]
        public void Employee_Delegate_Fails()
        {
            var hall = new Hall();
            var inventor = new Inventor();
            var employee = new Employee();

            employee.Clean(hall);
            employee.Fix(inventor);

            Assert.Null(employee.CalculateExpenses(DateTime.MinValue, DateTime.MaxValue));
            Assert.Null(employee.RentCost(DateTime.MinValue, DateTime.MaxValue));
        }

        [Fact]
        public void Employee_Delegate_Succeeds()
        {
            var hall = new Hall();
            var inventor = new Inventor();
            var employee = new Employee(new ExpensesStrategy(), new RentStrategy());

            employee.Clean(hall);
            employee.Fix(inventor);

            Assert.NotNull(employee.CalculateExpenses(DateTime.MinValue, DateTime.MaxValue));
            Assert.NotNull(employee.RentCost(DateTime.MinValue, DateTime.MaxValue));
        }
    }
}
