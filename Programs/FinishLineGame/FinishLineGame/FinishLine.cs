using System;

namespace FinishLineGame
{
    public class FinishLine
    {
        private readonly int[] SUITS = new int[] {0, 1, 2, 3};
        private readonly int[] VALUES = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
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
            ValidateDeck();
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

        public void ValidateDeck(int position)
        {
            if (Array.IndexOf(Restricted_Values, this.Deck.Cards[position].Value) >= 0)

                while (true)
                {
                    int newPosition = this.Rand.Next(3, 51);
                    if (Array.IndexOf(Restricted_Values, this.Deck.Cards[newPosition].Value) >= 0)
                    {
                        continue;
                    }

                    Card temp = this.Deck.Cards[position];
                    this.Deck.Cards[position] = this.Deck.Cards[newPosition];
                    this.Deck.Cards[newPosition] = temp;

                    break;
                }
        }

        public void ValidateDeck()
        {
            int[] Restricted_Positions = {0, 1, 2, 51, 52, 53};
            foreach (var position in Restricted_Positions)
            {
                ValidateDeck(position);
            }
        }

        public void Turn(Player player)
        {
            DisplayBoard();
            string master = "";
            master += player.Name + "'s turn!\n";
            this.RedDie.Roll(this.Rand);
            this.BlackDie.Roll(this.Rand);
            int stopValue = this.RedDie.Val + this.BlackDie.Val;
            master += "Red: " + this.RedDie.Val + "\tBlack" + this.BlackDie.Val + "\tStop Value: " + stopValue + "\n";

            GetMarker("Red", RedDie, player, stopValue, master);
            GetMarker("Black", BlackDie, player, stopValue, master);
        }

        public void GetMarker(string dieName, Die die, Player player, int stopValue, string master)
        {
            Console.WriteLine(master);
            Console.WriteLine("Choose marker (a,b,c) for {0}", dieName);
            string input = Console.ReadLine();
            int inputIndex = player.FindMarker(input.ToUpper());
            player.Markers[inputIndex].Move(die.Val, stopValue, this.Deck);
            DisplayBoard();
        }

        public Player Round()
        {
            Turn(Player1);
            if (DidWin(Player1))
            {
                return Player1;
            }

            return null;
        }


        public void PlayGame()
        {
            while (true)
            {
                Player winner = Round();
                if (winner != null)
                {
                    Console.WriteLine("congrats {0}, you win!", winner.Name);
                    break;
                }
            }
        }

        private bool DidWin(Player player)
        {
            return player.HasMarkersAt(53) == "ABC";
        }
    }
}