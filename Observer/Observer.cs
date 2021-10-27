using System;

namespace Observer
{
    public class Observer : IObserver<DataObject>
    {
        private string _name = "";
        public IDisposable Unsubscriber;

        public Observer(string name)
        {
            _name = name;
        }
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(DataObject value)
        {
            Console.WriteLine($"Observer: '{_name}' gets new message: '{value.Data}'.");
        }
    }
}
