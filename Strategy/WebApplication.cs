namespace Strategy
{
    public class WebApplication
    {
        private EBrowserType _eBrowserType;

        public WebApplication(EBrowserType eBrowserType)
        {
            _eBrowserType = eBrowserType;
        }

        public AsyncResponse SendAsyncRequestToServer(string url)
        {
            IAsyncRequestStrategy asyncRequestStrategy;
            AsyncResponse asyncResponse = null;

            switch(_eBrowserType)
            {
                case EBrowserType.InternetExplorer:
                    asyncRequestStrategy = new XmlHttpRequestApi();
                    asyncRequestStrategy.SendRequest(url);
                    break;
                case EBrowserType.Chrome:
                    asyncRequestStrategy = new FetchApi();
                    asyncRequestStrategy.SendRequest(url);
                    break;
            }

            return asyncResponse;
        }
    }
}
