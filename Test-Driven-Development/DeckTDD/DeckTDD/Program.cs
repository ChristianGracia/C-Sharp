using System;
using System.Collections.Generic;

namespace DeckTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Card
    {
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card()
        {

        }
    }

    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
        }

        public Card CreateCard(int suit, int value)
        {
            Card card = new Card();
            card.Value = value;
            card.Suit = suit;
            return card;
        }

        public void AddCardToDeck(Card card)
        {
            Cards.Add(card);
        }
    }
}
