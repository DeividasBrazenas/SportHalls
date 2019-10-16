namespace SportHalls.Mixin
{
    using System;
    using Expenses;
    using Improvements;
    using Rent;

    public class Inventor : IExpensesStrategy, IImprovementStrategy, IRentStrategy
    {
        private readonly IExpensesStrategy _expensesStrategy;
        private readonly IImprovementStrategy _improvementStrategy;
        private readonly IRentStrategy _rentStrategy;
        public int Quality { get; set; }

        public Inventor(IExpensesStrategy expensesStrategy = null, IImprovementStrategy improvementStrategy = null, IRentStrategy rentStrategy = null)
        {
            _expensesStrategy = expensesStrategy;
            _improvementStrategy = improvementStrategy;
            _rentStrategy = rentStrategy;
        }

        public void MakeSound()
        {
            Console.WriteLine("Badum tss");
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