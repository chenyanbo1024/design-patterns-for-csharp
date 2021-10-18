namespace Core.Factory.FactoryMethod.Factory
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            IShapeFactory factory = null;
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.ToUpper().Equals("CIRCLE"))
            {
                factory = new CircleFactory();
            }
            else if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                factory = new RectangleFactory();
            }
            else if (shapeType.ToUpper().Equals("SQUARE"))
            {
                factory = new SquareFactory();
            }
            return factory.GetShapeFactory();
        }
    }
}