using System;

namespace SportHalls.TemplatePattern
{
    using Halls;
    using Inventor;

    class Program
    {
        static void Main(string[] args)
        {
            var tennisCourt = new HallEMRandAAS(true);
            var basketballHall = new HallCRSandAAS(true);

            var startTime = new DateTime(2019, 05, 09, 19, 00, 00);
            var endTime = new DateTime(2019, 05, 09, 21, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");
            Console.WriteLine($"Tennis court rent price - {tennisCourt.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall rent price - {basketballHall.CalculateTotalRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            var tennisCourtForMembers = new HallEMRandNAS(false);
            var basketballHallForMembers = new HallCRSandAAS(false);

            startTime = new DateTime(2019, 05, 09, 21, 30, 00);
            endTime = new DateTime(2019, 05, 09, 23, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Tennis court (member) rent price - {tennisCourtForMembers.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Basketball hall (member) rent price - {basketballHallForMembers.CalculateTotalRentCost(startTime, endTime)}");

            Console.WriteLine("\n----------------------------------------------------------\n");

            var basketball = new InventorCRS();
            var tennisBalls = new InventorCRS();
            var tennisBallsMachine = new InventorCRS();
            var tennisRacket = new InventorCRS();

            startTime = new DateTime(2019, 05, 09, 13, 30, 00);
            endTime = new DateTime(2019, 05, 09, 16, 00, 00);

            Console.WriteLine($"Start time - {startTime:yyyy-mm-dd HH:mm}. End time - {endTime:yyyy-mm-dd HH:mm}");

            Console.WriteLine($"Basketball rent price - {basketball.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls rent price - {tennisBalls.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis balls machine rent price - {tennisBallsMachine.CalculateTotalRentCost(startTime, endTime)}");
            Console.WriteLine($"Tennis racket rent price - {tennisRacket.CalculateTotalRentCost(startTime, endTime)}");
        }
    }
}
