namespace Builder
{
    public class Dog
    {
        private string _name;
        private string _color;
        private int _size;

        public Dog(string name, string color, int size)
        {
            _name = name;
            _color = color;
            _size = size;
        }

        public override string ToString()
        {
            return $"Dog:\nName: {_name}, Color: {_color}, Size: {_size}";
        }
    }
}
