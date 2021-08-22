using System;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        public abstract void SetHandler(Handler handler);

        public virtual void HandleRequest(Object obj)
        {
            Console.WriteLine("The Request cannot be handled.");
        }
    }
}
