namespace ImmutableStackKata
{
    public class ImmutableStack<T> : IStack<T>
    {
        private sealed class EmptyStack : IStack<T>
        {
            public IStack<T> Push(T value)
            {
                throw new System.NotImplementedException();
            }

            public IStack<T> Pop(T value)
            {
                throw new System.NotImplementedException();
            }

            public T Peek()
            {
                throw new System.NotImplementedException();
            }

            public bool IsEmpty => true;
        }

        public IStack<T> Push(T value)
        {
            throw new System.NotImplementedException();
        }

        public IStack<T> Pop(T value)
        {
            throw new System.NotImplementedException();
        }

        public T Peek()
        {
            throw new System.NotImplementedException();
        }

        public bool IsEmpty { get; }
        private static readonly EmptyStack _empty = new EmptyStack();
        public static IStack<T> Empty => _empty;
    }
}