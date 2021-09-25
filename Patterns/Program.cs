using Patterns.AbstractFactory;
using Patterns.Adapter;
using Patterns.Command;
using Patterns.Decorator;
using Patterns.FactoryMethod;
using Patterns.Observer;
using Patterns.Strategy;

namespace Patterns {
    class Program {
        static void Main(string[] args) {
            IRunner runner = new StrategyRunner();
            runner.Run();

            runner = new CommandRunner();
            runner.Run();

            runner = new AbstractFactoryRunner();
            runner.Run();

            runner = new AdapterRunner();
            runner.Run();

            runner = new DecoratorRunner();
            runner.Run();

            runner = new FactoryRunner();
            runner.Run();
            
            runner = new ObserverRunner();
            runner.Run();
        }
    }
}