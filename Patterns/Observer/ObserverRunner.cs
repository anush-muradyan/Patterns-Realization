namespace Patterns.Observer {
    public class ObserverRunner : AbstractRunner {
        public override void Run() {
            var subject = new Subject<int>();
            subject.Add(new FirstNumberObserver());
            subject.Add(new SecondNumberObserver());
            subject.Notify(4);
        }
    }
}