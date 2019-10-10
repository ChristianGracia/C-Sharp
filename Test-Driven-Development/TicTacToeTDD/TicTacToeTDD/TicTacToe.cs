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

            [Test]
            public void MoveSameSquare_ThrowsException()
            {
                Assert.Throws<InvalidOperationException>(() =>
                {
                    var game = new Game();
                    game.MakeMove(1);
                    game.MakeMove(1);
                });
            }

    }

        public class Game
        {
            public int MoveCounter { get; private set; }

            private readonly State[] _board = new State[9];

            public Game()
            {
                for(int i = 0; i < _board.Length; i++)
                {
                    _board[i] = State.Unset;
                }
            }

            public void MakeMove(int index)
            {
                if (index < 1 || index > 9)
                    throw new ArgumentOutOfRangeException();

                if (GetState(index) != State.Unset)
                    throw new InvalidOperationException();

                _board[index - 1] = MoveCounter % 2 == 0 ? State.Cross : State.Zero;

                MoveCounter++;
            }

            private State GetState(int index)
            {
                return _board[index - 1];
            }
        }

        public enum State
        {
            Cross,
            Zero,
            Unset

        }
}