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
    }
}