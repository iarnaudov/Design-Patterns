using _07._StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._StrategyPattern
{
    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return strategy.ExecuteOperation(num1, num2);
        }
    }
}
