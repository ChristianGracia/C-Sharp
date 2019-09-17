using System;

namespace FinishLineGame
{
    public class FinishLine
    {
        private readonly int[] SUITS = new int[] { 0, 1, 2, 3 };
        private readonly int[] VALUES = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        private const int NUM_JOKERS = 2;
        private readonly string[] MARKER_NAMES;
        public Deck Deck;
        public Die RedDie;
        public Die BlackDie;
        public Player Player1;
        public int Players;
        public Random Rand;

        public FinishLine(int players, string player1Name)
        {
            this.Players = players;
            this.Player1 = new Player(player1Name, this.MARKER_NAMES);
            this.Rand = new Random();
            this.Deck = new Deck();
        }
    }
}