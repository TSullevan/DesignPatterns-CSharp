namespace Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private string _name;
        private string _color;
        private int _size;

        public Dog Build()
        {
            return new Dog(_name, _color, _size);
        }

        public string GetColor()
        {
            return _color;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetSize()
        {
            return _size;
        }

        public IBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        public IBuilder SetName(string name)
        {
            _name = name;
            return this;
        }

        public IBuilder SetSize(int size)
        {
            _size = size;
            return this;
        }
    }
}
