namespace Visitor
{
    internal class Product : IElement //Element_B
    {
        public string Name;
        public float Price;
        public ProductType ProductType;

        public Product(string name, float price, ProductType productType)
        {
            Name = name;
            Price = price;
            ProductType = productType;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
