using Patterns.FactoryMethod.Factory;

namespace Patterns.FactoryMethod.ConctreteFactory {
    public class ShapeFactory : AbstractFactory<ShapeProduct> {
        public override ShapeProduct Create() {
            return null;
        }

        public TConcrete Create<TConcrete>() where TConcrete : ShapeProduct, new() {
            var product = new TConcrete();
            return product;
        }
    }
}