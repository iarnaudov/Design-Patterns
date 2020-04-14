using _05._AbstractFactory.Enums;
using _05._AbstractFactory.Interfaces;

namespace _05._AbstractFactory.Factory
{
    public abstract class AbstractFactory
    {
        public abstract Shape GetShape(ShapeType shapeType);
    }
}
