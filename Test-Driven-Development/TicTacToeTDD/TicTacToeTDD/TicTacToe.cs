using System;
using NUnit.Framework;

namespace Tests
{

        [TestFixture]
        public class TicTacToeTests
        {
            [Test]
            public void CreateGame_ZeroMoves()
            {
                Game game = new Game();
                Assert.AreEqual(0, game.MoveCounter);

            }

            [Test]
            public void MakeMove_Increment()
            {
                Game game = new Game();
                game.MakeMove(1);
                Assert.AreEqual(1, game.MoveCounter);

            }

            [Test]
            public void MakeInvalidMove_ThrowsException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    var game = new Game();
                    game.MakeMove(0);
                });
            }

    }

        public class Game
        {
            public int MoveCounter { get; private set; }

            public void MakeMove(int index)
            {
                if (index < 1 || index > 9)
                    throw new ArgumentOutOfRangeException();
                MoveCounter++;
            }
        }
}