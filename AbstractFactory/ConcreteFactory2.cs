namespace AbstractFactory
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ConcreteProductA_2();
        }

        public IProductB CreateProductB()
        {
            return new ConcreteProductB_2();
        }
    }
}
