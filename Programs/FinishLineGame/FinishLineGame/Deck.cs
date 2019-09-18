using System;
using System.Collections.Generic;

namespace FinishLineGame
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();

        public Deck(int[] Values, int[] Suits, int NumOfJokers)
        {
            foreach (int suit in Suits)
            {
                foreach (var value in Values)
                {
                    this.Cards.Add(new Card(value, suit));
                }
            }

            for (int jkr = 0; jkr < NumOfJokers; jkr++)
            {
                this.Cards.Add(new Card(0, 0));
            }
        }

        public void Shuffle(Random rand)
        {
            for (int index = this.Cards.Count - 1; index > 0; index--)
            {
                int position = rand.Next(index + 1);
                Card temp = this.Cards[index];
                this.Cards[index] = this.Cards[position];
                this.Cards[position] = this.Cards[index];
                this.Cards[position] = temp;

            }
        }
    }
}