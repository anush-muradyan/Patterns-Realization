using System;

namespace Patterns.Command {
    public class CommandRunner :AbstractRunner{
        public override void Run() {
            var holder = new CommandHolder();
            var result=holder.RunPrintCommand("Hello World");
            Console.WriteLine(result);
        }
    }
}