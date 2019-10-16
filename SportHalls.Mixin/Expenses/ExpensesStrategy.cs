namespace SportHalls.Mixin.Expenses
{
    using System;

    public class ExpensesStrategy : IExpensesStrategy
    {
        public double? CalculateExpenses(DateTime startDateTime, DateTime endDateTime)
        {
            return (endDateTime - startDateTime).TotalMinutes / 3;
        }
    }
}