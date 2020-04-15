using _03.CommandPattern.Commands;
using _03.CommandPattern.Models;
using System;

namespace _03.CommandPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Stock stock1 = new Stock("NASDAQ", 10);
            Stock stock2 = new Stock("Google", 30);
            Stock stock3 = new Stock("Apple", 20);

            BuyStock order1 = new BuyStock(stock1);
            BuyStock order2 = new BuyStock(stock2);
            SellStock order3 = new SellStock(stock3);

            CommandInvoker invoker = new CommandInvoker();
            invoker.TakeOrder(order1);
            invoker.TakeOrder(order2);
            invoker.TakeOrder(order3);

            invoker.ExecuteOrders();

            // Wait for user
            Console.ReadKey();
        }
    }
}
