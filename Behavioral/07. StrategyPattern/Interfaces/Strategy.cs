using System;
using System.Collections.Generic;
using System.Text;

namespace _07._StrategyPattern.Interfaces
{
    public interface Strategy
    {
        public int ExecuteOperation(int num1, int num2);
    }
}
