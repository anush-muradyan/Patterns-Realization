namespace Patterns.Observer {
    public class FirstNumberObserver : Observer<int> {
        public int number;

        public override void Update(int number) {
            this.number = number;
        }
    }
}