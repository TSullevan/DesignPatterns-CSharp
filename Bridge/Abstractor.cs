namespace Bridge
{
    public abstract class Abstractor
    {
        protected IImplementor implementor;

        public Abstractor(IImplementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void Method_A();
        public abstract void Method_B();
    }
}
