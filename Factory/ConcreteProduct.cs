namespace Factory
{
    public class ConcreteProduct : Product
    {
        private int _index;
        public ConcreteProduct(int index)
        {
            _index = index;
        }

        public override string ToString()
        {
            return $"Product_{_index}";
        }
    }
}
