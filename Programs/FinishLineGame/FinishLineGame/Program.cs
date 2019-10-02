using System;
using System.Runtime.CompilerServices;

namespace FinishLineGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new FinishLine(1, new string[] {"player1", "player2"});
            game.PlayGame();
        }
    }
}
