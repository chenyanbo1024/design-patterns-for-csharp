namespace Core.Factory.FactoryMethod.Factory
{
    public class CircleFactory : IShapeFactory
    {
        public IShape GetShapeFactory()
        {
            return new Circle();
        }
    }
}