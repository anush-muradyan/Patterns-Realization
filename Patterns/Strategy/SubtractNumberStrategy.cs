namespace Patterns.Strategy {
    public class SubtractNumberStrategy : AbstractNumberStrategy {
        public SubtractNumberStrategy(int a, int b) : base(a, b) {
        }

        public override int GetResult() {
            return A - B;
        }
    }
}