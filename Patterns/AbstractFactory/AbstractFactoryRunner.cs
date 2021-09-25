using System;
using Patterns.AbstractFactory.ConcreteFactory.ColorProduct;
using Patterns.AbstractFactory.ConcreteFactory.ShapeProduct;
using Patterns.AbstractFactory.Factory;

namespace Patterns.AbstractFactory {
    public class AbstractFactoryRunner : AbstractRunner {
        public override void Run() {
            ShapeFactory shapeFactory = new ShapeFactory();
            var rectangleProduct = shapeFactory.Create<RectangleProduct>();
            Console.WriteLine(rectangleProduct.Corners);
            ColorFactory colorFactory = new ColorFactory();
            var redProduct = colorFactory.Create<RedProduct>();
            Console.WriteLine(redProduct.Color);
        }
    }
}