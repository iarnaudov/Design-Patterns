using _05._AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._AbstractFactory.Models
{
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
