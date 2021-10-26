using System.Collections.Generic;

namespace Flyweight
{
    public static class FlyweightFactory
    {
        private static Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

        public static IFlyweight GetFlyweight(string property_1)
        {
            if(_flyweights.ContainsKey(property_1))
            {
                return _flyweights[property_1];
            }
            else
            {
                _flyweights.Add(property_1, new SharedFlyweight(property_1));
                return _flyweights[property_1];
            }
        }
    }
}
