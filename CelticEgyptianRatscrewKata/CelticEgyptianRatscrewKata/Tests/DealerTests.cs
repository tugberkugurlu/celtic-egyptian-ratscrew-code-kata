using System.Collections.Generic;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class DealerTests
    {
        [Test]
        public void DealingAnEmptyDeckToOnePile()
        {
            var deck = Cards.Empty();
            var dealer = new Dealer();

            var hands = dealer.Deal(1, deck);

            var expectedHands = new List<Cards> { Cards.Empty() };
            CollectionAssert.AreEqual(expectedHands, hands);
        }
    }
}