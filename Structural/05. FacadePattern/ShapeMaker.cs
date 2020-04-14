using _05._FacadePattern.Interfaces;
using _05._FacadePattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._FacadePattern
{
    class ShapeMaker
    {
        private Shape circle;
        private Shape square;
        private Shape rectangle;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

    }
}
