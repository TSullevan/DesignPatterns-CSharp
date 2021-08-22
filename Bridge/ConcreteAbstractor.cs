namespace Bridge
{
    public class ConcreteAbstractor : Abstractor
    {
        public ConcreteAbstractor(IImplementor implementor) : base(implementor) { }
        
        public override void Method_A()
        {
            base.implementor.Method_A();
        }

        public override void Method_B()
        {
            base.implementor.Method_B();
        }
    }
}
