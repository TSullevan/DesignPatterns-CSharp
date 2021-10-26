using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade - Start\n");

            string value = "   Hello World_123!";
            Console.Write("Original - ");
            Console.WriteLine(value.ToCharArray());

            IComponent component = new Component();
            Console.Write("Component - ");
            Console.WriteLine(component.Trim(value));

            IComponent decoratorUpper = new DecoratorUpper(new Component());
            Console.Write("DecoratorUpper - ");
            Console.WriteLine(decoratorUpper.Trim(value));

            IComponent decoratorLower = new DecoratorLower(new Component());
            Console.Write("DecoratorLower - ");
            Console.WriteLine(decoratorLower.Trim(value));

            IComponent decoratorNumeric = new DecoratorNumeric(new Component());
            Console.Write("DecoratorNumeric - ");
            Console.WriteLine(decoratorNumeric.Trim(value));

            IComponent decoratorUpperLower = new DecoratorUpper(new DecoratorLower(new Component()));
            Console.Write("DecoratorUpperLower - ");
            Console.WriteLine(decoratorUpperLower.Trim(value));

            Console.WriteLine("Facade - End\n");
        }
    }
}
