using System;

namespace Prototype
{
    public class ConcreteProduct_2 : IProduct, IPrototype
    {
        public int Value;
        public SubObject subObject;

        public ConcreteProduct_2(int value, SubObject subObject)
        {
            this.Value = value;
            this.subObject = subObject;
        }

        public object Clone()
        {
            ConcreteProduct_2 copy = (ConcreteProduct_2)this.MemberwiseClone();
            copy.subObject = new SubObject(subObject.SubValue);
            return copy;
        }

        public void Method()
        {
            Console.WriteLine($"Hash: {this.GetHashCode()}, Value: {Value}, Hash SubObject: {subObject.GetHashCode()}, Value SubObject: {subObject.SubValue}");
        }
    }
}
