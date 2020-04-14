using _05._FacadePattern.Interfaces;
using System;

namespace _05._FacadePattern.Models
{
    public class Square : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square...");
        }
    }
}
