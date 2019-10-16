namespace SportHalls.Mixin.Rent
{
    using System;

    public interface IRentStrategy
    {
        double? RentCost(DateTime startDateTime, DateTime endDateTime);
    }
}