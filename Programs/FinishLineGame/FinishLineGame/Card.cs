using System.Collections.Generic;

namespace FinishLineGame
{
    public class Card
    {
        public int Suit;
        public int Value;
        private Dictionary<int, string> SUIT_MAP = new Dictionary<int, string>
        {
            {0, "\u2663" },
            {1, "\u2660" },
            {2, "\u2665" },
            {3, "\u2666" }
        };

        private Dictionary<int, string> VAL_MAP = new Dictionary<int, string>
        {
            {1, "Ac"},
            {10, "10"},
            {11, "Ja"},
            {12, "Qa"},
            {13, "Ki"}
        };

        public Card( int value, int suit)
        {
            this.Value = value;
            this.Suit = suit;
        }

        public string Display()
        {
            if (this.Value == 0)
                return "Jkr";

            if (this.VAL_MAP.ContainsKey(this.Value))
                return this.SUIT_MAP[this.Suit] + this.VAL_MAP[this.Value];

            return this.SUIT_MAP[this.Suit] + "0" + this.Value;

        }
    }
}