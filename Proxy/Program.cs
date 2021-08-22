using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proxy - Start\n");

            IService concreteService = new ConcreteService();
            IService proxy = new Proxy(concreteService);

            Console.WriteLine("Login with ConcreteService");
            concreteService.Login(15);
            concreteService.Login(18);

            Console.WriteLine("\nLogin with Proxy");
            proxy.Login(15);
            proxy.Login(18);

            Console.WriteLine("\nProxy - End");
        }
    }
}
