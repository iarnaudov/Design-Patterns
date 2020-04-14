using _07._ProxyPattern.Interfaces;
using _07._ProxyPattern.Models;
using System;

namespace _07._ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("test_10mb.jpg");

            //image will be loaded from disk
            image.Display();
            Console.WriteLine();

            //image will not be loaded from disk
            image.Display();
        }
    }
}
