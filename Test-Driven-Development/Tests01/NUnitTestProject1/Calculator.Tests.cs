using System.Security.Principal;
using NUnit.Framework;
using Tests01;

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
}