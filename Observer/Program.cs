using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer - Start\n");

            Provider provider = new Provider();

            DataObject dataObject = new DataObject(provider);

            Observer observer_1 = new Observer("Observer 1");
            Observer observer_2 = new Observer("Observer 2");

            observer_1.Unsubscriber = provider.Subscribe(observer_1);
            observer_2.Unsubscriber = provider.Subscribe(observer_2);

            dataObject.SetData("Message 1");

            Console.WriteLine("\n");

            observer_1.Unsubscriber.Dispose();
            dataObject.SetData("Message 2");

            Console.WriteLine("\nObserver - End");
        }
    }
}
