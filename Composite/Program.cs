using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Composite - Start\n");

            Leaf leaf1 = new Leaf("Leaf_1");
            Leaf leaf2 = new Leaf("Leaf_2");

            Composite composite1 = new Composite("Composite_1");
            Composite composite2 = new Composite("Composite_2");

            composite1.components.Add(composite2);
            composite1.components.Add(leaf1);

            composite2.components.Add(leaf2);

            composite1.Operation();

            Console.WriteLine("\nComposite - End");
        }
    }
}
