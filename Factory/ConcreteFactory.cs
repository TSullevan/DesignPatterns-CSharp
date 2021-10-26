namespace Factory
{
    public class ConcreteFactory : IFactory
    {
        private int _index = 0;
        public Product CreateProduct()
        {
            return new ConcreteProduct(_index++);
        }
    }
}
