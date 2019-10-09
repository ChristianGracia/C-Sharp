using System.Collections.Generic;
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
        [TestCase(2, "II")]
        public void Parse(int expected, string roman)
        {
            Assert.AreEqual(expected, Roman.Parse(roman));
        }
    }

    public class Roman
    {
        private static Dictionary<char, int> _map = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'H', 1000},
        };
        public static int Parse(string roman)
        {
            int result = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                result += _map[roman[i]];
            }

            return result;

        }
    }
}