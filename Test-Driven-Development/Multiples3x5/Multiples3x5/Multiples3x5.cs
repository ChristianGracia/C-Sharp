using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class MultiplesTest
    {
        [TestCase("divisible by 3", 3)]
        [TestCase("divisible by 3", 6)]
        [TestCase("divisible by 5", 5)]
        [TestCase("not divisible 3 or 5", 7)]
        [TestCase("divisible by 5", 10)]
        public void TestMultiples(string expected, int number)
        {
            Assert.AreEqual(expected, Multiples(number));
        }

        private string Multiples(int number)
        {
            if (number % 3 == 0)
                return "divisible by 3";
            if(number % 5 == 0)
                return "divisible by 5";
            return "not divisible 3 or 5";
        }
    }
}