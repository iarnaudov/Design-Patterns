using _04._DecoratorPattern.Interfaces;
using _04._DecoratorPattern.Models;
using System;

namespace _04._DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape redCircle = new RedBorderDecorator(new Circle());
            IShape redRectangle = new RedBorderDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border:");
            circle.Draw();

            Console.WriteLine("\nCircle of red border:");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border:");
            redRectangle.Draw();
        }
    }
}
