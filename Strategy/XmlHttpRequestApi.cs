using System;

namespace Strategy
{
    public class XmlHttpRequestApi : IAsyncRequestStrategy
    {
        public AsyncResponse SendRequest(String url)
        {
            AsyncResponse asyncresponse = new AsyncResponse();
            Console.WriteLine("Sent async network request using XmlHttpRequestApi");
            return asyncresponse;
        }
    }
}
