using Patterns.FactoryMethod.Factory;

namespace Patterns.FactoryMethod.ConctreteFactory {
    public abstract class ShapeProduct : IAbstractProduct {
        public int Corners { get; private set; }


        protected ShapeProduct(int corners) {
            Corners = corners;
        }
    }
}