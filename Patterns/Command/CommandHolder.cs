using System;

namespace Patterns.Command {
    public class CommandHolder {
        private ICommand<string> PrintCommand =>
            new StringCommand(Console.WriteLine, data => !string.IsNullOrEmpty(data));

        public bool RunPrintCommand(string data) {
            return PrintCommand.Execute(data);
        }
    }
}