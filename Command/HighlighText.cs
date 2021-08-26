using System;

namespace Command
{
    public class HighlighText : ICommand
    {
        private string _text;
        private HighlightConfig _config;
        public HighlighText(string text, HighlightConfig config)
        {
            _text = text;
            _config = config;
        }
        public void Execute()
        {
            Console.WriteLine($"HighlighText: {_text}");
        }

        public void Undo()
        {
            Console.WriteLine($"UnHighlighText: {_text}");
        }
    }
}
