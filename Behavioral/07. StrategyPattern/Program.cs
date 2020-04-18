using _07._StrategyPattern.Operations;
using System;

namespace _07._StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new AddOperation());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new SubstractOperation());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new MultiplyOperation());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));
        }
    }
}
