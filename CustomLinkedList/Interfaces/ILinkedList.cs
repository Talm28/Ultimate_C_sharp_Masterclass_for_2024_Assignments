namespace CustomLimkedList.Interfaces
{
    public interface ILinkedList<T> : ICollection<T>
    {
        void AddToFront(T item);
        void AddToEnd(T item);
    }
}