using NUnit.Framework;

namespace ImmutableStackKata
{

    public interface IStack<T>
    {
        IStack<T> Push(T value);
        IStack<T> Pop(T value);
        T Peek();
        bool IsEmpty { get; }

    }

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

            public bool IsEmpty { get; }
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
    }

    [TestFixture]
    public class ImmutableStackTests
    {


     
    }

}