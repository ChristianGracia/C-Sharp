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
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var redDie = new Die();
            redDie.Roll(rand);
            Card aCard = new Card(0, 11);
            Console.WriteLine(aCard.Value + " " + aCard.Suit);
        }
    }
}
