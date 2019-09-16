using System.Collections.Generic;

namespace FinishLineGame
{
    public class Deck
    {
        public List<Card> Cards;

        public Deck(int[] suits, int[] values, int numOfJokers)
        {
            foreach (int suit in suits)
            {
                foreach (var value in values)
                {
                    this.Cards.Add(new Card(value, suit));
                }
            }

            for (int jkr = 0; jkr < numOfJokers; jkr++)
            {
                this.Cards.Add(new Card(0, 0));
            }
        }
    }
}