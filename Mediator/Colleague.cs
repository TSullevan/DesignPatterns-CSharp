using System;

namespace Mediator
{
    public abstract class Colleague
    {
        protected readonly IMediator Mediator;

        protected Colleague(IMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void HandleEvent(string @event);
    }
}
