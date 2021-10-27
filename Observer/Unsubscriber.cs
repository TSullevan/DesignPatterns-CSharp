using System;
using System.Collections.Generic;

namespace Observer
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<DataObject>> _observers;
        private IObserver<DataObject> _observer;
        public Unsubscriber(List<IObserver<DataObject>> observers, IObserver<DataObject> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            _observers.Remove(_observer);
        }
    }
}
