using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : IComponent
    {
        public List<IComponent> components = new List<IComponent>();
        private string _name;
        public Composite(string name)
        {
            _name = name;
        }

        public void Operation()
        {
            Console.WriteLine(_name);
            foreach(IComponent component in components)
            {
                component.Operation();
            }
        }
    }
}
