using System;
using System.Collections.Generic;
using System.Text;

namespace _03.CommandPattern.Models
{
    public class Stock
    {
        private string Name;
        private int Quantity;

        public Stock(string name, int quantity)
        {
            this.Name = name;
            this.Quantity = quantity;
        }

        public void Buy()
        {
            Console.WriteLine("Stock [ Name: " + Name + ", Quantity: " + Quantity + " ] bought");
        }
        public void Sell()
        {
            Console.WriteLine("Stock [ Name: " + Name + ", Quantity: " + Quantity + " ] sold");
        }
    }
}
