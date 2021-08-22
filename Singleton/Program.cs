using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton - Start\n");

            Console.WriteLine(Singleton.Instance.Value);
            Singleton.Instance.Value++;
            Console.WriteLine(Singleton.Instance.Value);

            Console.WriteLine("\nSingleton - End");
        }
    }
}
