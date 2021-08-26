namespace Command
{
    public class Button
    {
        ICommand command;
        public Button(ICommand command) => this.command = command;
        public void Click() => command.Execute();
    }
}
