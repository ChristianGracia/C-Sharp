using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MultiplesTest
    {
        [TestCase("divisible by 3", 3)]
        [TestCase("divisible by 3", 6)]
        [TestCase("divisible by 5", 5)]
        public void TestMultiples(string expected, int number)
        {
            Assert.AreEqual(expected, Multiples(number));
        }

        private string Multiples(int number)
        {
            if (number % 3 == 0)
                return "divisible by 3";
            return "divisible by 5";
        }
    }
}