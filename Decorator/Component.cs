namespace Decorator
{
    public class Component : IComponent
    {
        public char[] Trim(string value)
        {
            return $"Component -> '{value.Trim()}'".ToCharArray();
        }
    }
}
