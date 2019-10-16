namespace SportHalls.Mixin
{
    using System;
    using Expenses;
    using Improvements;
    using Rent;

    public class Hall : IExpensesStrategy, IImprovementStrategy, IRentStrategy
    {
        private readonly IExpensesStrategy _expensesStrategy;
        private readonly IImprovementStrategy _improvementStrategy;
        private readonly IRentStrategy _rentStrategy;
        public int Quality { get; set; }

        public Hall(IExpensesStrategy expensesStrategy = null, IImprovementStrategy improvementStrategy = null, IRentStrategy rentStrategy = null)
        {
            _expensesStrategy = expensesStrategy;
            _improvementStrategy = improvementStrategy;
            _rentStrategy = rentStrategy;
            Quality = 0;
        }

        public void Entertain()
        {
            Console.WriteLine("Let meeeeeeee entertain youuuuuu");
        }

        public double? CalculateExpenses(DateTime startDateTime, DateTime endDateTime)
        {
            return _expensesStrategy?.CalculateExpenses(startDateTime, endDateTime);
        }

        public double? ImprovementCost(int quality)
        {
            return _improvementStrategy?.ImprovementCost(quality);
        }

        public double? RentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _rentStrategy?.RentCost(startDateTime, endDateTime);
        }
    }
}