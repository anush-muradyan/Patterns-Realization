namespace Patterns.Command {
    public interface ICommand<T> {
        bool Execute(T data);
    }

    public interface ICommand {
        bool Execute();
    }
}