using _05._FacadePattern.Interfaces;
using System;

namespace _05._FacadePattern.Models
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }
    }
}
