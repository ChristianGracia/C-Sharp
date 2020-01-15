using System;
using System.Collections.Generic;
using System.Text;
using DeckTDD;
using NUnit.Framework;

namespace DeckTDDTests
{
    public class DeckUnitTests
    {
        private Deck deck;

        [SetUp]
        public void SetUpDeck()
        {
            deck = new Deck();
        }

        [Test]
        public void Deck_CreatedDeckDataTypeIsList()
        {

            Assert.IsTrue(deck.GetType().GetProperty("Cards") != null);

        }

        [Test]
        public void Deck_AddCard_CountReturnsTrue()
        {
            deck.Cards.Add(new Card());
            Assert.AreEqual(1, deck.Cards.Count);
        }

        [Test]
        public void Deck_MaxDeckCountIs52()

        {

            for (int i = 0; i < 52; i++)
            {
                deck.Cards.Add(new Card());
            }

            Assert.AreEqual(52, deck.Cards.Count);

        }

        [Test]
        public void Deck_Add2CardsRemove1Card_CountIs1()
        {
            deck.Cards.Add(new Card());
            deck.Cards.Add(new Card());
            deck.Cards.RemoveAt(0);
            Assert.AreEqual(1, deck.Cards.Count);
        }

        [Test]
        public void Deck_CreateCard_ReturnsCardWithSuitAs1()
        {
            Card card = deck.CreateCard(1, 0);

            Assert.AreEqual(1, card.Suit);
        }
        [Test]
        public void Deck_CreateCard_ReturnsCardWithSuitAs2()
        {
            Card card = deck.CreateCard(2, 0);

            Assert.AreEqual(2, card.Suit);
        }

        [Test]
        public void Deck_CreateCard_ReturnsCardWithValueAs2()
        {
            Card card = deck.CreateCard(2, 2);

            Assert.AreEqual(2, card.Value);
        }

        [Test]
        public void Deck_CreateCard_ReturnsCardWithValueAs3()
        {
            Card card = deck.CreateCard(2, 3);

            Assert.AreEqual(3, card.Value);
        }

        [Test]
        public void Deck_CreatedCard_IsAddedToDeckAndDeckCountIs1()
        {
            Card card = deck.CreateCard(2, 3);

            deck.AddCardToDeck(card);

            Assert.AreEqual(1, deck.Cards.Count);
        }

    }
}