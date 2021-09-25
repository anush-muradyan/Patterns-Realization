namespace Patterns.Strategy {
    public class AddNumberStrategy : AbstractNumberStrategy {
        public AddNumberStrategy(int a, int b) : base(a, b) {
        }

        public override int GetResult() {
            return A + B;
        }
    }
}