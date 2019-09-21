using System;
using SportHalls.TemplatePattern.Halls.Basketball;
using SportHalls.TemplatePattern.Halls.Tennis.Members;
using SportHalls.TemplatePattern.Halls.Tennis.RegularPeople;
using SportHalls.TemplatePattern.Inventor.Basketball;
using SportHalls.TemplatePattern.Inventor.Tennis;

namespace SportHalls.TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tennisCourt = new TennisCourtAggressiveAdvertisement(true);
            var basketballHall = new BasketballHallAggressiveAdvertisement(true);

            var startTime = new DateTime(2019, 05, 09, 19, 00, 00);
            var endTime = new DateTime(2019, 05, 09, 21, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");
            Console.WriteLine($"Tennis court rent price - {tennisCourt.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall rent price - {basketballHall.CalculateRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            var tennisCourtForMembers = new TennisCourtForMembersAggressiveAdvertisement(false);
            var basketballHallForMembers = new BasketballHallForMembersAggressiveAdvertisement(false);

            startTime = new DateTime(2019, 05, 09, 21, 30, 00);
            endTime = new DateTime(2019, 05, 09, 23, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Tennis court (member) rent price - {tennisCourtForMembers.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall (member) rent price - {basketballHallForMembers.CalculateRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            IRentable basketball = new Basketball();
            IRentable tennisBalls = new TennisBalls();
            IRentable tennisBallsMachine = new TennisBallsMachine();
            IRentable tennisRacket = new TennisRacket();

            startTime = new DateTime(2019, 05, 09, 13, 30, 00);
            endTime = new DateTime(2019, 05, 09, 16, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Basketball rent price - {basketball.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls rent price - {tennisBalls.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls machine rent price - {tennisBallsMachine.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis racket rent price - {tennisRacket.CalculateRentCost(startTime, endTime)}");
        }
    }
}
