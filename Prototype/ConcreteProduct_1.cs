using System;

namespace Prototype
{
    public class ConcreteProduct_1 : IProduct
    {
        public void Method()
        {
            Console.WriteLine($"Hash: {this.GetHashCode()}");
        }
    }
}
