namespace Patterns.Strategy {
    public interface IStrategy<T> {
        T GetResult();
    }
}