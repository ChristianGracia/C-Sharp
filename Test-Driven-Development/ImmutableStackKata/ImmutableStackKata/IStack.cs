namespace ImmutableStackKata
{
    public interface IStack<T>
    {
        IStack<T> Push(T value);
        IStack<T> Pop(T value);
        T Peek();
        bool IsEmpty { get; }

    }
}