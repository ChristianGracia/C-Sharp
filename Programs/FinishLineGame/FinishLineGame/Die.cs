using System;

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
}