namespace Core.Factory.FactoryMethod.Factory
{
    public class SquareFactory : IShapeFactory
    {
        public IShape GetShapeFactory()
        {
            return new Square();
        }
    }
}