using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class ShufflerTests
    {
        [Test]
        public void ShufflingEmptyDeckReturnsEmptyDeck()
        {
            var deck = Cards.Empty();
            var shuffler = new Shuffler();

            var shuffledDeck = shuffler.Shuffle(deck);

            var expectedDeck = Cards.Empty();
            Assert.That(shuffledDeck, Is.EqualTo(expectedDeck));
        }

        [Test]
        public void ShufflingDeckWithOneCardReturnsDeckWithOneCard()
        {
            var deck = Cards.With(AceOfClubs());
            var shuffler = new Shuffler();

            var shuffledDeck = shuffler.Shuffle(deck);

            var expectedDeck = Cards.With(AceOfClubs());
            Assert.That(shuffledDeck, Is.EqualTo(expectedDeck));
        }

        private static Card AceOfClubs()
        {
            return new Card(Suit.Clubs, Rank.Ace);
        }
    }
}