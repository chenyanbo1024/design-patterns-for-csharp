using Core.Factory.SimpleFactory;
using Microsoft.AspNetCore.Mvc;

namespace Core.Start.Controllers
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        [HttpGet("simple")]
        public IActionResult SimpleFactory()
        {
            ShapeFactory shapeFactory = new();

            //获取 Circle 的对象，并调用它的 draw 方法
            Factory.SimpleFactory.IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //调用 Circle 的 draw 方法
            var draw1 = shape1.Draw();

            //获取 Rectangle 的对象，并调用它的 draw 方法
            Factory.SimpleFactory.IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //调用 Rectangle 的 draw 方法
            var draw2 = shape2.Draw();

            //获取 Square 的对象，并调用它的 draw 方法
            Factory.SimpleFactory.IShape shape3 = shapeFactory.GetShape("SQUARE");

            //调用 Square 的 draw 方法
            var draw3 = shape3.Draw();

            return Ok($"{draw1},{draw2},{draw3}");
        }

        [HttpGet("method")]
        public IActionResult FactoryMethod()
        {
            Factory.FactoryMethod.IShape shape1 = new Factory.FactoryMethod.Factory.ShapeFactory().GetShape("CIRCLE");
            var draw1 = shape1.Draw();

            Factory.FactoryMethod.IShape shape2 = new Factory.FactoryMethod.Factory.ShapeFactory().GetShape("RECTANGLE");
            var draw2 = shape2.Draw();

            Factory.FactoryMethod.IShape shape3 = new Factory.FactoryMethod.Factory.ShapeFactory().GetShape("SQUARE");
            var draw3 = shape3.Draw();

            return Ok($"{draw1},{draw2},{draw3}");
        }
    }
}