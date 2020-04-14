using _06._Flyweight.Models;
using System;

namespace _06._Flyweight
{
    class Program
    {
        private static string[] colors = new string[] { "Black", "Red", "Yellow", "Green", "Blue", "Purple" };
        private static Random random = new Random();

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(GetRandomColor());
                circle.SetX(GetRandomX());
                circle.SetY(GetRandomY());
                circle.SetRadius(100);
                circle.Draw();
            }
            Console.ReadKey();        
        }

        private static string GetRandomColor()
        {   
            return colors[(int)(random.Next(0, colors.Length))];
        }
        private static int GetRandomX()
        {
            return (int)((random.Next(0, colors.Length)));
        }
        private static int GetRandomY()
        {
            return (int)((random.Next(0, colors.Length)));
        }
    }
}
