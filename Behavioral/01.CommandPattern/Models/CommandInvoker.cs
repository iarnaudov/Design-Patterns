using _03.CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern
{
    class CommandInvoker
    {
        private List<Order> orderList = new List<Order>();

        public void TakeOrder(Order order)
        {
            orderList.Add(order);
        }

        public void ExecuteOrders()
        {
            foreach (Order order in orderList)
            {
                order.Execute();
            }

            orderList.Clear();
        }

    }
}
