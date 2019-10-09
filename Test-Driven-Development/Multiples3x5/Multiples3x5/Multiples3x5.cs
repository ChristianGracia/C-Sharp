using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MultiplesTest
    {
        [Test]
        public void TestMultiples()
        {
            Assert.AreEqual("divisible by 3", Multiples(3));
            Assert.AreEqual("divisible by 5", Multiples(5));
        }

        private string Multiples(int number)
        {
            if (number == 3)
                return "divisible by 3";
            return "divisible by 5";
        }
    }
}