using System.Security.Principal;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNumbers_ValidValues_ReturnsCorrectResult()
        {
            var sut = new Calculator();
            int result = sut.AddNumbers(2, 1);


            Assert.That(result, Is.EqualTo(3));
        }
    }

    public class Calculator
    {
        public int AddNumbers(int x, int y)
        {
            return x + y;
        }
    }
}