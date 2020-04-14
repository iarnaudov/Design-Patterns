using _04._DecoratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._DecoratorPattern
{
    public class RedBorderDecorator : IShape
    {
        protected IShape decoratedShape;

        public RedBorderDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder(decoratedShape);
        }

        private void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
