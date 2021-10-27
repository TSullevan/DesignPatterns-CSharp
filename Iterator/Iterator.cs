namespace Iterator
{
    public class Iterator : IIterator
    {
        private Collection _collection;
        private int _current;

        public Iterator(Collection collection)
        {
            _collection = collection;
            _current = 0;
        }

        public object CurrentItem()
        {
            return _current >= _collection.Count;
        }

        public object First()
        {
            return _collection[0];
        }

        public bool IsDone()
        {
            return _current >= _collection.Count;
        }

        public object Next()
        {
            if(!IsDone())
            {
                return _collection[_current++];
            }
            return null;
        }
    }
}
