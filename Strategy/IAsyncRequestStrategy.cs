using System;

namespace Strategy
{
    public interface IAsyncRequestStrategy
    {
        AsyncResponse SendRequest(String url);
    }
}
