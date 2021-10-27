using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder - Start\n");

            IBuilder builder = new ConcreteBuilder();
            Director director = new Director();

            Dog defaultDog = director.Construct(builder);
            Console.WriteLine(defaultDog.ToString());

            IBuilder builder2 = new ConcreteBuilder();
            builder2.SetName("Doguinho").SetColor("Black").SetSize(100);

            Dog secondDog = director.Construct(builder2);
            Console.WriteLine(secondDog.ToString());

            Console.WriteLine("\nBuilder - End");
        }
    }
}
