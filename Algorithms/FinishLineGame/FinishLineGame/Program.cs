using System;
using System.Runtime.CompilerServices;

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
        public static void Main(string[] args)
        {
            var game = new FinishLine(1, "player1");
            Console.WriteLine("player 1s {0} marker is at {1}", game.Player1.Markers[1].Name, game.Player1.Markers[1].Position  );
            Console.WriteLine("first card is {0}", game.Deck.Cards[0].Display());
            Console.WriteLine("last card is {0}", game.Deck.Cards[50].Display());
            Console.WriteLine("red die is {0}", game.RedDie.Val);
            Console.WriteLine("black die is {0}", game.BlackDie.Val);
            game.DisplayBoard();
         
        }
    }
}
