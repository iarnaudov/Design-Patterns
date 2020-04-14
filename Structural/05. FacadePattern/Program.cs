﻿using System;

namespace _05._FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
