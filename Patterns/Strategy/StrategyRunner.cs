using System;

namespace Patterns.Strategy {
    public class StrategyRunner : AbstractRunner {
        public override void Run() {
            if (!readNumber(out var number1) || !readNumber(out var number2)) {
                Console.WriteLine("Input correct number");
                return;
            }

            var operation = Console.ReadLine();
            if (operation == null) {
                return;
            }

            IStrategy<int> strategy = null;
            switch (operation) {
                case "+":
                    strategy = new AddNumberStrategy(number1, number2);
                    break;
                case "-":
                    strategy = new SubtractNumberStrategy(number1, number2);
                    break;
                default:
                    Console.WriteLine("Input correct operation");
                    return;
            }

            var result = strategy?.GetResult();
            Console.WriteLine(result);
        }

        private bool readNumber(out int number) {
            return int.TryParse(Console.ReadLine(), out number);
        }
    }
}