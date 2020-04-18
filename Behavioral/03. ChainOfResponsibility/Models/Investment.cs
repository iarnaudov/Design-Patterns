using System;
using System.Collections.Generic;
using System.Text;

namespace _03._ChainOfResponsibility.Models
{
    public class Investment
    {
        public int Amount { get; set; }
        public string Title { get; set; }

        public Investment(string title, int amount)
        {
            this.Amount = amount;
            this.Title = title;
        }
    }
}
