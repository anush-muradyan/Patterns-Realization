namespace Patterns.Observer {
    public class SecondNumberObserver : Observer<int> {
        public int number;

        public override void Update(int number) {
            this.number = number;
        }
    }
}