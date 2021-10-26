namespace AbstractFactory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA_1();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB_1();
        }
    }
}
