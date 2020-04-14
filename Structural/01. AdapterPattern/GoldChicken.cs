using _01._AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01._AdapterPattern
{
    public class GoldChicken : IChicken
    {
        public void Cluck()
        {
            Console.WriteLine("Cluck Cluck Cluck");
        }

        public void Jump()
        {
            Console.WriteLine("Jump 3 meters");
        }
    }
}
