namespace SportHalls.Mixin
{
    using System;
    using Expenses;
    using Rent;

    public class Employee : IExpensesStrategy, IRentStrategy
    {
        private readonly IExpensesStrategy _expensesStrategy;
        private readonly IRentStrategy _rentStrategy;
        public int Age { get; set; }

        public Employee(IExpensesStrategy expensesStrategy = null, IRentStrategy rentStrategy = null)
        {
            _expensesStrategy = expensesStrategy;
            _rentStrategy = rentStrategy;
            Age = 18;
        }

        public void Clean(Hall hall)
        {
            if (hall.Quality < 6)
            {
                Console.WriteLine("Hall is really dirty. Hard to clean all the mess");
                return;
            }

            Console.WriteLine("Hall looks pretty good");
        }

        public void Fix(Inventor inventor)
        {
            if (inventor.Quality < 8)
            {
                Console.WriteLine("Inventor item is damaged a little bit");
                return;
            }

            Console.WriteLine("All good with the item");
        }

        public double? CalculateExpenses(DateTime startDateTime, DateTime endDateTime)
        {
            return _expensesStrategy?.CalculateExpenses(startDateTime, endDateTime);
        }

        public double? RentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return _rentStrategy?.RentCost(startDateTime, endDateTime);
        }
    }
}