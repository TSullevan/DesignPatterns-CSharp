namespace Builder
{
    public interface IBuilder
    {
        public Dog Build();
        public IBuilder SetColor(string color);
        public IBuilder SetName(string name);
        public IBuilder SetSize(int size);
        public string GetColor();
        public string GetName();
        public int GetSize();
    }
}
