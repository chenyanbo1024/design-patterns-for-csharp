namespace Core.Factory.FactoryMethod.Factory
{
    public class RectangleFactory : IShapeFactory
    {
        public IShape GetShapeFactory()
        {
            return new Rectangle();
        }
    }
}