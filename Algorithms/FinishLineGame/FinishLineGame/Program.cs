using System;

//possible classes
//die
//deck
//card
//player
//marker
//game or board

//use hash map for key value pairs

namespace FinishLineGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] suits = new int [4] {0, 1, 2, 3};
            int[] values = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            var rand = new Random();

            var deck = new Deck(suits, values, 2);

            Console.WriteLine(deck.Cards[23].Display());
            deck.Shuffle(rand);
            Console.WriteLine(deck.Cards[23].Display());
            Console.WriteLine("\u2660");



        }
    }
}
