namespace Flyweight
{
    public class SharedFlyweight : IFlyweight
    {
        //intrisic State = shared
        string Property_1;
        string Property_2;
        string Property_3;
        string Property_4;

        public SharedFlyweight(string property_1)
        {
            Property_1 = property_1;
            Property_2 = Property_1 + "Something else";
            Property_3 = Property_2 + "Something else";
            Property_4 = Property_1 + Property_2;
        }
    }
}
