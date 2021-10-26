using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract Factory - Start\n");

            IAbstractFactory abstractFactory_1 = new ConcreteFactory1();
            IAbstractFactory abstractFactory_2 = new ConcreteFactory2();

            var productA1 = abstractFactory_1.CreateProductA();
            var productB1 = abstractFactory_1.CreateProductB();
            Console.WriteLine(productA1.GetName());
            Console.WriteLine(productB1.GetName());

            var productA2 = abstractFactory_2.CreateProductA();
            var productB2 = abstractFactory_2.CreateProductB();
            Console.WriteLine(productA2.GetName());
            Console.WriteLine(productB2.GetName());

            Console.WriteLine("\nAbstract Factory - End");
        }
    }
}
