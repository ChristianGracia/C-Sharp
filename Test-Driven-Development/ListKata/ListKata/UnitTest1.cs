using System.Collections.Generic;
using NUnit.Framework;

namespace ListKata
{
    [TestFixture]
    public class LinkedListTests
    {
        [Test]
        public void CreateNode_SetsValueAndNextIsNull()
        {
            ListNode<int> node = new ListNode<int>();
            Assert.AreEqual(1, node.Value);
            Assert.IsNull(node.Next);
        }
    }

    public class ListNode<T>
    {
        public object Next { get; set; }
        public double Value { get; set; }
    }

}