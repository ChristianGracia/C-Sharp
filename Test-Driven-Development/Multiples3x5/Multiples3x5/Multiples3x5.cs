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
        }

        private string Multiples(int number)
        {
            return null;
        }
    }
}