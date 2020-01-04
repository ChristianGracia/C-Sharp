using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Api;

namespace ListKata
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void CreateNode_SetsValueAndNextIsNull()
        {
            ListNode<int> node = new ListNode<int>(1);
            Assert.AreEqual(1, node.Value);
            Assert.IsNull(node.Next);
        }

        [Test]
        public void AddFirst_HeadAndTailAreSame()
        {
            MyLinkedList<int> list = new MyLinkedList<int>();
            list.AddFirst(1);

            Assert.AreSame(list.Head, list.Tail );
        }

        [Test]
        public void AddFirstTwoElements_ListIsInCorrectState()
        {
            var list = new MyLinkedList<int>();
            list.AddFirst(1);
            list.AddFirst(2);

            Assert.AreEqual(1, list.Tail.Value);
            Assert.AreEqual(2, list.Head.Value);
            Assert.AreEqual(2, list.Count);
            Assert.AreSame(list.Head.Next, list.Tail);

        }
    }

    public class MyLinkedList<T>
    {
        public ListNode<T> Tail { get; private set; }
        public ListNode<T> Head { get; private set; }
        public int Count { get; set; }

        public void AddFirst(T value)
        {
            AddFirst(new ListNode<T>(value));

        }

        private void AddFirst(ListNode<T> node)
        {
 
            //save head
            ListNode<T> temp = Head;
            //point head to new node
            Head = node;
            //insert in to list behind head
            Head.Next = temp;

            Count++;
            if (Count == 1)
            {
                Tail = Head;
            }


        }
    }

    public class ListNode<T>
    {
        public ListNode(T value)
        {
            Value = value;

        } 
        public ListNode<T> Next { get; set; }
        public T Value { get; set; }
    }

}