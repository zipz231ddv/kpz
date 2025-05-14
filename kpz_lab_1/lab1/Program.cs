using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Reporting reporting = new Reporting(warehouse);

            reporting.RegisterIncome("cat", 200, new UAH(199, 99), "inch", "brown");
            reporting.RegisterIncome("dog", 232, new UAH(222, 22), "foot", "white");
            reporting.RegisterIncome("frog", 999, new USD(666, 66), "yard", "green");

            Console.WriteLine("\npre-shipment report");
            reporting.GenerateInventoryReport();

            reporting.RegisterShipment("cat", 4);
            reporting.RegisterShipment("dog", 3);

            Console.WriteLine("\npost-shipment report");
            reporting.GenerateInventoryReport();

            Console.WriteLine("\ncurrency");
            Money someAmount = new UAH(100, 75);
        }
    }
}