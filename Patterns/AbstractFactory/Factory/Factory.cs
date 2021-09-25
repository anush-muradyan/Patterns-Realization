namespace Patterns.AbstractFactory.Factory {
    public abstract class AbstractFactory {
    }

    public class Factory<TProduct> : AbstractFactory where TProduct : IAbstractProduct {
        public  TConcrete Create<TConcrete>() where TConcrete : TProduct, new() {
            var product = new TConcrete();
            return product;
        }
    }
}