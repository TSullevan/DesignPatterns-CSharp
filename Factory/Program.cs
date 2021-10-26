using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory - Start\n");
            IFactory factory = new ConcreteFactory();
            Product product1 = factory.CreateProduct();
            Console.WriteLine(product1.ToString());

            Product product2 = factory.CreateProduct();
            Console.WriteLine(product2.ToString());

            Product product3 = factory.CreateProduct();
            Console.WriteLine(product3.ToString());

            Product product4 = factory.CreateProduct();
            Console.WriteLine(product4.ToString());

            Console.WriteLine("\nFactory - End");
        }
    }
}
