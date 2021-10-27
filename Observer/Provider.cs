using System;
using System.Collections.Generic;

namespace Observer
{
    public class Provider : IObservable<DataObject>
    {
        private List<IObserver<DataObject>> _observers = new List<IObserver<DataObject>>();
        public IDisposable Subscribe(IObserver<DataObject> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
            return new Unsubscriber(_observers, observer);
        }

        public void Notify(DataObject data)
        {
            foreach(Observer observer in _observers)
            {
                observer.OnNext(data);
            }
        }
    }
}
