using Patterns.AbstractFactory.Factory;

namespace Patterns.AbstractFactory {
    public interface IColorProduct : IAbstractProduct {
        string Color { get; }
    }
}