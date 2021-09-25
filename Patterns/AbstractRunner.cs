using System;

namespace Patterns {
    public abstract class AbstractRunner : IRunner {
        protected AbstractRunner() {
            Console.WriteLine($"----==== {GetType()} ====----");
        }

        public abstract void Run();
    }
}