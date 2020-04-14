using System;
using System.Collections.Generic;
using System.Text;

namespace _05._AbstractFactory.Factory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(bool isRounded)
        {
            if (isRounded)
            {
                return new RoundedShapeFactory();
            }
            else
            {
                return new ShapeFactory();
            }
        }
    }
}
