using System;

namespace Strategy
{
    public class FetchApi : IAsyncRequestStrategy
    {
        public AsyncResponse SendRequest(String url)
        {
            AsyncResponse asyncresponse = new AsyncResponse();
            Console.WriteLine("Sent async network request using FetchApi");
            return asyncresponse;
        }
    }
}
