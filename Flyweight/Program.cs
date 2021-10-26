using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flyweight - Start\n");

            //List<Context> contexts = new List<Context>(); // 2.8 GB ~ 3.1 GB
            //for(int i = 0; i < 8000000; i++)
            //{
            //    Context context = new Context("Argument");
            //    contexts.Add(context);
            //}
            //Console.WriteLine(contexts.Count);

            List<ContextWithFlyweight> contextsFly = new List<ContextWithFlyweight>(); // 689 MB ~ 758 MB
            for (int i = 0; i < 8000000; i++)
            {
                ContextWithFlyweight context = new ContextWithFlyweight("Argument");
                contextsFly.Add(context);
            }
            Console.WriteLine(contextsFly.Count);

            Console.ReadLine();

            Console.WriteLine("\nFlyweight - End");
        }
    }
}
