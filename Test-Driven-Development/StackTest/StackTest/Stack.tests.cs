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
            MyStack stack = new MyStack();
            Assert.IsTrue(stack.IsEmpty);

        }
    }

    public class MyStack
    {
        public bool IsEmpty
        {
            get { return true; }
        }
    }
}
