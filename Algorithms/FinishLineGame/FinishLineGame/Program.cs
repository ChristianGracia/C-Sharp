using System;

//possible classes
//die
//deck
//card
//player
//marker
//game or board

namespace FinishLineGame
{
    public class Die
    {
        public int Val;
        private int Sides;
        public int Color;
  
        public Die(int sides, int color)
        {
            this.Sides = sides;
            this.Color = color;
            this.Val = 1;
        }

        public Die(int sides)
        {
            this.Sides = sides;
            this.Val = 1;
        }

        public Die()
        {
            this.Sides = 6;
            this.Val = 1;
        }

        public void Roll(Random rand)
        {
            this.Val = rand.Next(1, this.Sides + 1);
        }
    }

    public class Card
    {
        public int Suit;
        public int Value;

        public Card(int suit, int value)
        {
            this.Suit = suit;
            this.Value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var redDie = new Die();
            redDie.Roll(rand);

        }
    }
}
