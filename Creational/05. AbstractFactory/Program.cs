using _05._AbstractFactory.Enums;
using _05._AbstractFactory.Factory;
using _05._AbstractFactory.Interfaces;
using System;

namespace _05._AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //get normal shape factory
            AbstractFactory shapeFactory = FactoryProducer.GetFactory(false);

            Shape normalSquare = shapeFactory.GetShape(ShapeType.Square);
            normalSquare.Draw();

            Shape normalRectangle = shapeFactory.GetShape(ShapeType.Rectangle);
            normalRectangle.Draw();

            //get rounded shape factory
            AbstractFactory roundedShapeFactory = FactoryProducer.GetFactory(true);

            Shape roundedSquare = roundedShapeFactory.GetShape(ShapeType.Square);
            roundedSquare.Draw();

            Shape roundedRectangle = roundedShapeFactory.GetShape(ShapeType.Rectangle);
            roundedRectangle.Draw();
        }
    }
}
