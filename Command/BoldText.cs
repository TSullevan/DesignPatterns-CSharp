using System;

namespace Command
{
    public class BoldText : ICommand
    {
        private string _text;
        public BoldText(string text)
        {
            _text = text;
        }
        public void Execute()
        {
            Console.WriteLine($"BoldText: {_text}");
        }

        public void Undo()
        {
            Console.WriteLine($"UnBoldText: {_text}");
        }
    }
}
