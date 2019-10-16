namespace SportHalls.Mixin.Expenses
{
    using System;

    public interface IExpensesStrategy
    {
        double? CalculateExpenses(DateTime startDateTime, DateTime endDateTime);
    }
}