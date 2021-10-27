namespace Visitor
{
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
