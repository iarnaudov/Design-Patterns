using _04._DecoratorPattern.Interfaces;
using System;

namespace _04._DecoratorPattern.Models
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing circle...");
        }
    }
}
