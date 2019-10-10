using NUnit.Framework;

namespace Tests
{

        [TestFixture]
        public class TicTacToeTests
        {
        [Test]
            public void CreateGame_ZeroMoves()
            {
                var game = new Game();
                Assert.AreEqual(0, Game.MoveCounter);

            }

        }

        public class Game
        {
            public static int MoveCounter = 0;
        }
}