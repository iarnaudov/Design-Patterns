using _03.CommandPattern.Interfaces;
using _03.CommandPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern.Commands
{
    public class BuyStock : Order
    {
        private Stock stock;

        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            stock.Buy();
        }
    }
}
