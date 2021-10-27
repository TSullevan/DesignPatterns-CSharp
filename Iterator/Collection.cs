using System.Collections;

namespace Iterator
{
    public class Collection : ICollection
    {
        private ArrayList items = new ArrayList();
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }

        public int Count { get { return items.Count; } }

        public int this[int index]
        {
            get { return (int)items[index]; }
            set { items.Add(value); }
        }
    }
}
