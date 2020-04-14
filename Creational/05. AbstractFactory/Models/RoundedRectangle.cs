using _05._AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._AbstractFactory.Models
{
    public class RoundedRectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RoundedRectangle::draw() method.");
        }
    }
}
