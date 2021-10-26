namespace Decorator
{
    public abstract class Decorator : IComponent
    {
        protected IComponent component;
        protected Decorator(IComponent component)
        {
            this.component = component;
        }
        public virtual char[] Trim(string value)
        {
            return this.component.Trim(value);
        }
    }
}
