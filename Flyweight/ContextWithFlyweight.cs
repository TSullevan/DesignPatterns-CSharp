
using System;

namespace Flyweight
{
    public class ContextWithFlyweight
    {
        //extrisic State = unshared
        string Id;

        IFlyweight flyweight;

        public ContextWithFlyweight(string property_1)
        {
            flyweight = FlyweightFactory.GetFlyweight(property_1);
            Id = DateTime.Now.GetHashCode().ToString("x");
        }
    }
}
