using System.Collections.Generic;

namespace Visitor
{
    internal class Shelf : IElement //Element_A
    {
        public string Name;
        public List<Product> Products = new List<Product>();
        public Shelf(string name)
        {
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
