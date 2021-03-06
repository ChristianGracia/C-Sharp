namespace ImmutableStackKata
{
    public class ImmutableStack<T> : IStack<T>
    {

        private sealed class EmptyStack : IStack<T>
        {
            public IStack<T> Push(T value)
            {
                return new ImmutableStack<T>(value, this);
            }

            public IStack<T> Pop()
            {
                throw new System.InvalidOperationException();
            }

            public T Peek()
            {
                throw new System.InvalidOperationException();
            }

            public bool IsEmpty => true;
        }

        private ImmutableStack(T head, IStack<T> tail)
        {
            _head = head;
            _tail = tail;
        }

        public IStack<T> Push(T value)
        {
            return new ImmutableStack<T>(value, this);
        }

        public IStack<T> Pop()
        {
            return _tail;
        }

        public T Peek()
        {
            return _head;
        }

        public bool IsEmpty { get; }
        private static readonly EmptyStack _empty = new EmptyStack();
        private readonly T _head;
        private readonly IStack<T> _tail;
        public static IStack<T> Empty => _empty;
    }
}