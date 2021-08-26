using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Command");

            Console.WriteLine("Static Command");

            string text = "Command Design Pattern";
            Button buttonHighlighText = new Button(new HighlighText(text, new HighlightConfig()));
            buttonHighlighText.Click();
            Button buttonBoldText = new Button(new BoldText(text));

            buttonBoldText.Click();

            Console.WriteLine("Static Command");

            Console.WriteLine("Dynamic Command");

            var textContext = new TextContext();
            var command1 = new DynamicCommand<TextContext>(textContext, tc => tc.HighlightText(text));
            command1.Execute();

            var command2 = new DynamicCommand<TextContext>(textContext, tc => tc.BoldText(text));
            command2.Execute();

            Console.WriteLine("Dynamic Command");

            Console.WriteLine("End Command");
        }
    }
}
