using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mediator - Start\n");

            Form form = new Form();
            Button button = new Button(form);
            TextBox textBox = new TextBox(form);

            form.AddColleague(button);
            form.AddColleague(textBox);

            button.TriggerClick("Clicked now!");
            textBox.TriggerTextChanged("Text Changed to some invalid value");

            Console.WriteLine("\nMediator - End");
        }
    }
}
