using System;
using Patterns.FactoryMethod.ConctreteFactory;

namespace Patterns.FactoryMethod {
    public class FactoryRunner : AbstractRunner {
        public override void Run() {
            var factory = new ShapeFactory();
            ShapeProduct product = factory.Create<TriangleProduct>();
            Console.WriteLine("Triangle corner: " + product.Corners);
            product = factory.Create<RectangleProduct>();
            Console.WriteLine("Rectangle corners: " + product.Corners);
        }
    }
}