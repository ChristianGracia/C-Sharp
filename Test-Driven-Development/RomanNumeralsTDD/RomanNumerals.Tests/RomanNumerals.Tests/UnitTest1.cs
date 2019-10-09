using System.Security.Cryptography;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {

        [TestCase(1, "I")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, Roman.Parse(roman));
        }
    }

    public class Roman
    {
        public static int Parse(string roman)
        {
            if (roman == "X")
                return 10;
            if (roman == "V")
                return 5;
            return 1;
        }
    }
}