using _05._AbstractFactory.Enums;
using _05._AbstractFactory.Interfaces;
using _05._AbstractFactory.Models;

namespace _05._AbstractFactory.Factory
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override Shape GetShape(ShapeType shapeType)
        {
            if (shapeType.Equals(ShapeType.Rectangle))
            {
                return new RoundedRectangle();
            }
            else if (shapeType.Equals(ShapeType.Square))
            {
                return new RoundedSquare();
            }
            return null;
        }
    }
}
