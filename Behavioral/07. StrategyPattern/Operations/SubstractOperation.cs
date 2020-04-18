using _07._StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07._StrategyPattern.Operations
{
    public class SubstractOperation : Strategy
    {
        public int ExecuteOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
