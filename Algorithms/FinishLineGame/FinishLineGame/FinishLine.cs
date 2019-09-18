using System;

namespace FinishLineGame
{
    public class FinishLine
    {
        private readonly int[] SUITS = new int[] { 0, 1, 2, 3 };
        private readonly int[] VALUES = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        private const int NUM_JOKERS = 2;
        private readonly string[] MARKER_NAMES = new string[] {"a", "b", "c"};
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
            this.Deck = new Deck(this.VALUES, this.SUITS, NUM_JOKERS);
            this.RedDie = new Die(6, 0xFF0000);
            this.BlackDie = new Die(6, 0x000000);
            this.Deck.Shuffle(Rand);
            this.RedDie.Roll(Rand);
            this.BlackDie.Roll(Rand);
        }

        public void DisplayBoard()
        {
            string master = "\t";
            int counter = 0;

            foreach (Card card in this.Deck.Cards)
            {
                master += "[" + card.Display() + "]\t";
                counter++;
                if (counter == 9)
                {
                    counter = 0;
                    master += "\n\n\t";
                }
            }
            Console.WriteLine(master);

        }
    }
}