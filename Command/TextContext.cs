using System;

namespace Command
{
    public class TextContext
    {
        public void HighlightText(string text)
        {
            Console.WriteLine($"TextContext: HighlightText - {text}");
        }
        public void BoldText(string text)
        {
            Console.WriteLine($"TextContext: BoldText - {text}");
        }
    }
}
