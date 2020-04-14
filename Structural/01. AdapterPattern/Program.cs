using _01._AdapterPattern.Interfaces;
using System;

namespace _01._AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new GoldChicken();
            var duck = new ChickenAdapter(chicken);

            duck.Fly();
            duck.Quack();
        }
    }
}
