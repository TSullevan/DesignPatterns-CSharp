using System;

namespace ChainOfResponsibility
{
    public class HandleString : Handler
    {
        private Handler _handler;
        public override void SetHandler(Handler handler)
        {
            _handler = handler;
        }

        public override void HandleRequest(object obj)
        {
            if(obj.GetType() == typeof(String))
            {
                Console.WriteLine("The Argument is from type String.");
            }
            else
            {
                if(_handler != null)
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
