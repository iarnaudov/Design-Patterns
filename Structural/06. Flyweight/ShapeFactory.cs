using _06._Flyweight.Interfaces;
using _06._Flyweight.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Flyweight
{
    public class ShapeFactory
    {
        private static Dictionary<string, Circle> shapeStore = new Dictionary<string, Circle>();

        public static Shape GetCircle(string color)
        {
            Circle circle = null;
            if (shapeStore.ContainsKey(color))
            {
                circle = (Circle)shapeStore[color];
                Console.WriteLine(color + " Directly returned");
            } 
            else
            {
                circle = new Circle(color);
                shapeStore[color] = circle;
                Console.WriteLine("Creating circle for color: " + color);
            }
            return circle;
        }
    }
}
