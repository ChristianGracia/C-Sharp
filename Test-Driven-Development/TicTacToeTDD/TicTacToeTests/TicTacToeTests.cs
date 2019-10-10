using NUnit.Framework;
using TicTacToeTDD;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Game game = new Game();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}