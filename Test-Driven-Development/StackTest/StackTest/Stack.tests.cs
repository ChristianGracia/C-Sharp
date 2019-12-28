using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace StackTest
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void isEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new MyStack<int>();
            Assert.IsTrue(stack.IsEmpty);

        }

        [Test]
        public void Count_PushOneItem_ReturnsOne()
        {
            var stack = new MyStack<int>();
            stack.Push(1);
            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Pop_EmptyStack_ThrowsException()
        {
            var stack = new MyStack<int>();
            Assert.Throws<InvalidOperationException>(() => { stack.Pop(); });
        }

        [Test]
        public void Peek_PushTwoItems_ReturnsHeadItem()
        {

        }
    }

    public class MyStack<T>
    {
        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }

        public void Push(T value)
        {
            Count++;

        }

        public void Pop()
        {
            if(IsEmpty)
                throw new InvalidOperationException();
        }
    }
}
