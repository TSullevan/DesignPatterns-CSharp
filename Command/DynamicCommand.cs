using System;

namespace Command
{
    public class DynamicCommand<Receiver> : ICommand
    {
        private Receiver _receiver;
        private Action<Receiver> _action;
        public DynamicCommand(Receiver receiver, Action<Receiver> action)
        {
            _receiver = receiver;
            _action = action;
        }
        public void Execute()
        {
            _action(_receiver);
        }

        public void Undo()
        {
            //
        }
    }
}
