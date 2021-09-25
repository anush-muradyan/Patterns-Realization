namespace Patterns.Observer {
    public abstract class Observer<T> {
        public abstract void Update(T data);
    }
}