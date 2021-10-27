using System.Text;

namespace Visitor
{
    internal class InformationVisitor : IVisitor
    {
        public StringBuilder StringBuilder;

        internal InformationVisitor()
        {
            StringBuilder = new StringBuilder();
            StringBuilder.Append("Information about the Warehouse");
        }
        public void Visit(Shelf shelf)
        {
            StringBuilder
                .Append("\n")
                .Append(shelf.Name)
                .Append("\n");

            foreach(Product product in shelf.Products)
            {
                product.Accept(this);
            }
        }

        public void Visit(Product product)
        {
            StringBuilder
                .Append("\n")
                .Append(product.Name)
                .Append("\n")
                .Append(product.Price)
                .Append("\n")
                .Append(product.ProductType.ToString())
                .Append("\n");
        }
    }
}
