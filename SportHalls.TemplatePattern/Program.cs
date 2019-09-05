using System;
using SportHalls.TemplatePattern.Halls;

namespace SportHalls.TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tennisCourt = new TennisCourt();
            var basketballHall = new BasketballHall();
            var footballPitch = new FootballPitch();

            var startTime = new DateTime(2019, 05, 09, 19, 00, 00);
            var endTime = new DateTime(2019, 05, 09, 21, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");
            Console.WriteLine($"Tennis court rent price - {tennisCourt.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall rent price - {basketballHall.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Football pitch rent price - {footballPitch.CalculateRentCost(startTime, endTime)}");

            Console.WriteLine("----------------------------------------------------------");

            startTime = new DateTime(2019, 05, 09, 21, 30, 00);
            endTime = new DateTime(2019, 05, 09, 23, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");
            Console.WriteLine($"Tennis court rent price - {tennisCourt.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall rent price - {basketballHall.CalculateRentCost(startTime, endTime)}");
            Console.WriteLine($"Football pitch rent price - {footballPitch.CalculateRentCost(startTime, endTime)}");

            Console.ReadKey();
        }
    }
}
