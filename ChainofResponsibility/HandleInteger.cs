using System;

namespace ChainOfResponsibility
{
    public class HandleInteger: Handler
    {
        private Handler _handler;
        public override void SetHandler(Handler handler)
        {
            _handler = handler;
        }

        public override void HandleRequest(object obj)
        {
            if (obj.GetType() == typeof(Int32))
            {
                Console.WriteLine("The Argument is from type Integer.");
            }
            else
            {
                if (_handler != null)
                {
                    _handler.HandleRequest(obj);
                }
                else
                {
                    base.HandleRequest(obj);
                }
            }
        }
    }
}
