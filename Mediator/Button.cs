using System;

namespace Mediator
{
    public class Button : Colleague
    {
        public Button(IMediator mediator) : base(mediator)
        {

        }

        public override void HandleEvent(string @event)
        {
            Console.WriteLine("Button - Handling Event : " + @event);
        }

        public void TriggerClick(string arg)
        {
            this.Mediator.Send("Event - " + arg, this);
        }
    }
}
