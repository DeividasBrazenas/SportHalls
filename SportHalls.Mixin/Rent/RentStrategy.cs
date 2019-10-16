namespace SportHalls.Mixin.Rent
{
    using System;

    public class RentStrategy : IRentStrategy
    {
        public double? RentCost(DateTime startDateTime, DateTime endDateTime)
        {
            return (endDateTime - startDateTime).TotalMinutes * 2;
        }
    }
}