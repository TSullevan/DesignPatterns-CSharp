namespace Iterator
{
    public interface IIterator
    {
        object First();
        object Next();
        bool IsDone();
        object CurrentItem();
    }
}
