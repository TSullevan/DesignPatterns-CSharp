using System;

namespace Bridge
{
    public class ConcreteImplementor_A : IImplementor
    {
        public void Method_A()
        {
            Console.WriteLine("\tThis is Method_A from Implementor_A");
        }

        public void Method_B()
        {
            Console.WriteLine("\tThis is Method_B from Implementor_A");
        }
    }
}
