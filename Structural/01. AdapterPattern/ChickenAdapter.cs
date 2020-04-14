using _01._AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _01._AdapterPattern
{
    class ChickenAdapter : IDuck
    {
        private readonly IChicken _chicken;

        public ChickenAdapter(IChicken chicken)
        {
            _chicken = chicken;
        }
        public void Quack()
        {
            _chicken.Cluck();
        }

        public void Fly()
        {
            for (var i = 0; i < 5; i++)
            {
                _chicken.Jump();
                _chicken.Jump();
                _chicken.Jump();
                Console.WriteLine("Walk 2 steps...");
                Thread.Sleep(1000);
            }
        }
    }
}
