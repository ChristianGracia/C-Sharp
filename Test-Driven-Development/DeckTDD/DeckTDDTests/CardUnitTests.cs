using DeckTDD;
using NUnit.Framework;

namespace DeckTDDTests
{
    public class Tests
    {

        [Test]
        public void Card_AssignValue_HasValue()
        {
            Card card = new Card();

            card.Value = 1;


            Assert.AreEqual(1, card.Value);
        }

        [Test]
        public void Card_AssignSuit_HasValue()
        {
            Card card = new Card();
            card.Suit = 1;
            Assert.AreEqual(1, card.Suit);
        }
    }
}