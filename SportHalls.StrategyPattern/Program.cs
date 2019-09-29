using System;
using SportHalls.StrategyPattern.AdvertisementStrategies;
using SportHalls.StrategyPattern.RentStrategies;

namespace SportHalls.StrategyPattern
{
    class Program
    {
        static void Main()
        {
            IRentable tennisCourt = new Hall(new ExpensiveRentStrategy(), true, new AggressiveAdvertisementStrategy());
            IRentable basketballHall = new Hall(new CheapRentStrategy(), true, new AggressiveAdvertisementStrategy());

            var startTime = new DateTime(2019, 05, 09, 19, 00, 00);
            var endTime = new DateTime(2019, 05, 09, 21, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Tennis court rent price - {tennisCourt.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall rent price - {basketballHall.CalculateTotalRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            tennisCourt = new Hall(new ExpensiveMemberRentStrategy(), false);
            basketballHall = new Hall(new CheapMemberRentStrategy(), false);

            startTime = new DateTime(2019, 05, 09, 21, 30, 00);
            endTime = new DateTime(2019, 05, 09, 23, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Tennis court (member) rent price - {tennisCourt.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall (member) rent price - {basketballHall.CalculateTotalRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            IRentable basketball = new Inventor(new CheapRentStrategy());
            IRentable tennisBalls = new Inventor(new CheapMemberRentStrategy());
            IRentable tennisBallsMachine = new Inventor(new VeryCheapRentStrategy());
            IRentable tennisRacket = new Inventor(new VeryCheapMemberRentStrategy());

            startTime = new DateTime(2019, 05, 09, 13, 30, 00);
            endTime = new DateTime(2019, 05, 09, 16, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Basketball rent price - {basketball.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls rent price - {tennisBalls.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls machine rent price - {tennisBallsMachine.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis racket rent price - {tennisRacket.CalculateTotalRentCost(startTime, endTime)}");
           
            Console.ReadKey();
        }
    }
}
