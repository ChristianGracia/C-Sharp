using System;
using System.Security.Cryptography.X509Certificates;

namespace FinishLineGame
{
    public class FinishLine
    {
        private readonly int[] SUITS = new int[] { 0, 1, 2, 3 };
        private readonly int[] VALUES = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        private static int NUM_JOKERS = 2;
        private readonly string[] MARKER_NAMES = new string[] {"a", "b", "c"};
        private readonly int[] Restricted_Values = new int[] {0, 1, 2, 11, 12, 13};
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
            Console.Clear();
            string Master = "";
            string CardRow = "\t";
            string PlayerRow = "\t";
            int counter = 0;
            foreach (Card card in this.Deck.Cards)
            {
                CardRow += "|" + card.Display() + "|";
                PlayerRow += " " + this.Player1.HasMarkersAt(counter) + " ";
                counter++;
                if (counter % 9 == 0)
                {
                    Master += CardRow + "\n" + PlayerRow + "\n\n";
                    CardRow = "\t";
                    PlayerRow = "\t";
                }
                else
                {
                    CardRow += "\t";
                    PlayerRow += "\t";
                }
            }
            Console.WriteLine(Master);

       
        }
        public void ValidateDeck()
        {
            for (int position = 0; position < 3; position++)
            {
                Array.IndexOf(Restricted_Values, this.Deck.Cards[position].Value)
            }

        }
    }
}