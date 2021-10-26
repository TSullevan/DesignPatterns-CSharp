using System;

namespace Composite
{
    public class Leaf : IComponent
    {
        private string _name;

        public Leaf(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine(_name);
        }
    }
}
