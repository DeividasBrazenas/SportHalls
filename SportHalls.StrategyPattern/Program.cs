using System;
using SportHalls.StrategyPattern.RentStrategy;
using SportHalls.StrategyPattern.RentStrategy.HallRent;
using SportHalls.StrategyPattern.RentStrategy.HallRent.Basketball;
using SportHalls.StrategyPattern.RentStrategy.HallRent.Football;
using SportHalls.StrategyPattern.RentStrategy.HallRent.Tennis;
using SportHalls.StrategyPattern.RentStrategy.InventorRent;
using SportHalls.StrategyPattern.RentStrategy.InventorRent.Basketball;
using SportHalls.StrategyPattern.RentStrategy.InventorRent.Football;
using SportHalls.StrategyPattern.RentStrategy.InventorRent.Skiing;
using SportHalls.StrategyPattern.RentStrategy.InventorRent.Tennis;

namespace SportHalls.StrategyPattern
{
    class Program
    {
        static void Main()
        {
            IRentable tennisCourt = new Hall(new TennisCourtRentStrategy());
            IRentable basketballHall = new Hall(new BasketballHallRentStrategy());
            IRentable footballPitch = new Hall(new FootballPitchRentStrategy());

            var startTime = new DateTime(2019, 05, 09, 19, 00, 00);
            var endTime = new DateTime(2019, 05, 09, 21, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Tennis court rent price - {tennisCourt.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall rent price - {basketballHall.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Football pitch rent price - {footballPitch.CalculateRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            tennisCourt = new Hall(new TennisCourtMemberRentStrategy());
            basketballHall = new Hall(new BasketballHallMemberRentStrategy());
            footballPitch = new Hall(new FootballPitchMemberRentStrategy());

            startTime = new DateTime(2019, 05, 09, 21, 30, 00);
            endTime = new DateTime(2019, 05, 09, 23, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Tennis court (member) rent price - {tennisCourt.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall (member) rent price - {basketballHall.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Football pitch (member) rent price - {footballPitch.CalculateRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            IRentable basketball = new Inventor(new BasketballRentStrategy());
            IRentable football = new Inventor(new FootballRentStrategy());
            IRentable skis = new Inventor(new SkisRentStrategy());
            IRentable snowboard = new Inventor(new SnowboardRentStrategy());
            IRentable tennisBalls = new Inventor(new TennisBallsRentStrategy());
            IRentable tennisBallsMachine = new Inventor(new TennisBallsMachineRentStrategy());
            IRentable tennisRacket = new Inventor(new TennisRacketRentStrategy());

            startTime = new DateTime(2019, 05, 09, 13, 30, 00);
            endTime = new DateTime(2019, 05, 09, 16, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Basketball rent price - {basketball.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Football rent price - {football.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Skis rent price - {skis.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Snowboard rent price - {snowboard.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls rent price - {tennisBalls.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls machine rent price - {tennisBallsMachine.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis racket rent price - {tennisRacket.CalculateRentCost(startTime, endTime)}");
           
            Console.ReadKey();
        }
    }
}
