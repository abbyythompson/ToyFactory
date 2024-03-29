﻿using System;
using ToyFactoryLibrary;

namespace ToyFactoryConsole
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(Constants.Welcome);

            var orderManager = new OrderManager(new ConsoleResponseManager(), new ConsoleReportGenerator()); 

            Console.Write(Constants.HowManyOrders);
            var numOfOrders = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= numOfOrders; i++)
            {
                orderManager.CollectOrder();
            }

            for (var i = 1; i <= numOfOrders; i++)
            {
                orderManager.GenerateReports(i);
            }
            
            orderManager.GenerateCuttingListOverallReport();
            orderManager.GeneratePaintingOverallReport();
        }
    }
}