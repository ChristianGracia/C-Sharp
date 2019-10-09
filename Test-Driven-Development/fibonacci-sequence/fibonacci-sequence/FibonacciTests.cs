using System;
using System.Reflection.Metadata.Ecma335;
using NUnit.Framework;

namespace fibonacci_sequence
{
    [TestFixture]
    public class FibonacciTests
    {
        [Test]
        public void TestFibonacci()
        {
            Assert.AreEqual(0, GetFibonacci(0));
        }
        private int GetFibonacci(int index)
        {
            return 0;
        }
    }
}
