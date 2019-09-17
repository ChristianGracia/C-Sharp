namespace FinishLineGame
{
    public class FinishLine
    {
        private readonly int[] _suits = new int[] { 0, 1, 2, 3 };
        private readonly int[] _values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        public Deck Deck;
        public Die RedDie;
        public Die BlackDie;
        public Player Player1;
        public int Players;
    }
}