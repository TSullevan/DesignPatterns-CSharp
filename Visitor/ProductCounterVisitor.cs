namespace Visitor
{
    internal class ProductCounterVisitor : IVisitor
    {
        public int Smartphones = 0;
        public int Tvs = 0;
        public int Notebooks = 0;

        public void Visit(Shelf shelf)
        {
            foreach(Product product in shelf.Products)
            {
                product.Accept(this);
            }
        }

        public void Visit(Product product)
        {
            switch(product.ProductType)
            {
                case ProductType.NOTEBOOK:
                    Notebooks++;
                    break;
                case ProductType.SMARTPHONE:
                    Smartphones++;
                    break;
                case ProductType.TV:
                    Tvs++;
                    break;
            }
        }
    }
}
