using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge - Start\n");

            IImplementor implementor_A = new ConcreteImplementor_A();
            IImplementor implementor_B = new ConcreteImplementor_B();

            Abstractor abstractor_A = new ConcreteAbstractor(implementor_A);
            Abstractor abstractor_B = new ConcreteAbstractor(implementor_B);

            abstractor_A.Method_A();
            abstractor_A.Method_B();

            abstractor_B.Method_A();
            abstractor_B.Method_B();

            Console.WriteLine("\nBridge - End");
        }
    }
}
