namespace Observer
{
    public class DataObject
    {
        private Provider _provider;
        public string Data { get; set; }

        public DataObject(Provider provider)
        {
            _provider = provider;
        }

        public void SetData(string message)
        {
            Data = message;
            _provider.Notify(this);
        }
    }
}
