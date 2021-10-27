namespace Visitor
{
    internal interface IVisitor
    {
        void Visit(Shelf shelf);
        void Visit(Product shelf);
    }
}
