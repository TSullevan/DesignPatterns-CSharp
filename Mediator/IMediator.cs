namespace Mediator
{
    public interface IMediator
    {
        void Send(string @event, Colleague colleague);
    }
}
