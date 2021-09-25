using System;

namespace Patterns.Command {
    public class StringCommand : ICommand<string> {
        private readonly Action<string> executor;
        private readonly Func<string, bool> canExecute;

        public StringCommand(Action<string> executor, Func<string, bool> canExecute = null) {
            this.executor = executor;
            this.canExecute = canExecute;
        }

        public bool Execute(string data) {
            if (!CanExecute(data)) {
                return false;
            }

            executor?.Invoke(data);
            return true;
        }

        private bool CanExecute(string data) {
            return canExecute != null && canExecute.Invoke(data);
        }
    }
}