using System.Collections.Generic;

namespace Mediator
{
    public class Form : IMediator
    {
        private readonly List<Colleague> colleagues = new List<Colleague>();

        public void AddColleague(Colleague colleague)
        {
            this.colleagues.Add(colleague);
        }

        #region Implementation of IMediator

        public void Send(string @event, Colleague colleague)
        {
            foreach(Colleague col in colleagues)
            {
                if(col != colleague)
                {
                    col.HandleEvent(@event);
                }
            }
        }
        #endregion
    }
}
