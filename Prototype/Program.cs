using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype - Start\n");

            ConcreteProduct_2 concreteProduct_2 = new ConcreteProduct_2(10, new SubObject(100));
            ConcreteProduct_1 concreteProduct_1 = new ConcreteProduct_1();
            Console.Write("ConcreteProduct_1:\t\t");
            concreteProduct_1.Method();
            Console.Write("ConcreteProduct_2:\t\t");
            concreteProduct_2.Method();

            Console.WriteLine();

            var copy = (ConcreteProduct_2)concreteProduct_2.Clone();
            Console.Write("ConcreteProduct_2:\t\t");
            concreteProduct_2.Method();
            Console.Write("ConcreteProduct_2 Copy:\t\t");
            copy.Method();

            Console.WriteLine();

            concreteProduct_2.Value = 20;
            Console.Write("ConcreteProduct_2 Value 20:\t");
            concreteProduct_2.Method();
            Console.Write("ConcreteProduct_2 Copy:\t\t");
            copy.Method();

            Console.WriteLine("\nPrototype - End");
        }
    }
}
