namespace FileManager
{
    interface IIterable<T>
    {
        void MoveNext();
        void MovePrevious();
        bool HasNext();
        bool HasPrevious();
        void Reset();

    }
}
