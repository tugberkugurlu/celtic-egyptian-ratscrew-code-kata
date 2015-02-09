using System;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void PlayerCanLayTopCard()
        {
            var player = new Player("Player");
            var topCard = new Card(Suit.Clubs, Rank.Ace);
            var hand = new[] {topCard, new Card(Suit.Hearts, Rank.Five)};
            player.DealHand(Cards.With(hand));
            Assert.AreEqual(topCard, player.LayCard());
        }

        [Test]
        public void PlayerCannotLayACardBeforeDealing()
        {
            var player = new Player("Player");
            Assert.Throws<InvalidOperationException>(() => player.LayCard());
        }

        [Test]
        public void PlayerCannotLayACardWithAnEmptyHand()
        {
            var player = new Player("Player");
            player.DealHand(Cards.Empty());
            Assert.Throws<InvalidOperationException>(() => player.LayCard());
        }
    }
}
