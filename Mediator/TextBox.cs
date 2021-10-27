using System;

namespace Mediator
{
    public class TextBox : Colleague
    {
        public TextBox(IMediator mediator) : base(mediator)
        {

        }

        public override void HandleEvent(string @event)
        {
            Console.WriteLine("TextBox - Handling Event : " + @event);
        }
        public void TriggerTextChanged(string arg)
        {
            this.Mediator.Send("Event - " + arg, this);
        }
    }
}
