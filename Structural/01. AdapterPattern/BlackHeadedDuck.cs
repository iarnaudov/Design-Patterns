using _01._AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._AdapterPattern
{
    public class BlackHeadedDuck : IDuck
    {
        public void Quack()
        {
            Console.WriteLine("Quack Quack Quack");
        }

        public void Fly()
        {
            Console.WriteLine("Flap Flap Flap");
        }
    }
}
