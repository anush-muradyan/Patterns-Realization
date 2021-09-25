using Patterns.AbstractFactory.Factory;

namespace Patterns.AbstractFactory {
    public interface IShapeProduct : IAbstractProduct {
        int Corners { get; }
    }
}