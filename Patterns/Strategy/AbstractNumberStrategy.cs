namespace Patterns.Strategy {
    public abstract class AbstractNumberStrategy : IStrategy<int> {
        protected int A { get; }
        protected int B { get; }

        protected AbstractNumberStrategy(int a, int b) {
            A = a;
            B = b;
        }

        public abstract int GetResult();
    }
}