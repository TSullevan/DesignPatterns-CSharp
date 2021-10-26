
using System;

namespace Flyweight
{
    public class Context
    {
        //extrisic State = unshared
        string Id;

        //intrisic State = shared
        string Property_1;
        string Property_2;
        string Property_3;
        string Property_4;

        public Context(string property_1)
        {
            Property_1 = property_1;
            Property_2 = Property_1 + "Something else";
            Property_3 = Property_2 + "Something else";
            Property_4 = Property_1 + Property_2;
            Id = DateTime.Now.GetHashCode().ToString("x");
        }
    }
}
