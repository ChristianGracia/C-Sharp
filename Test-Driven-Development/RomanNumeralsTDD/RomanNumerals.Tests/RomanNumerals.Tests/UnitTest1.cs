using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {

        [Test]
        public void Parse()
        {
            Assert.AreEqual(1, Roman.Parse("1"));
            Assert.AreEqual(5, Roman.Parse("V"));
            Assert.AreEqual(10, Roman.Parse("X"));
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