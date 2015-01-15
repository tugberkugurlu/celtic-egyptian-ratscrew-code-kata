using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class StackTests
    {
        [Test]
        public void ShouldReadTopCardOnStack()
        {
            var expectedCard = new Card(Suit.Clubs, Rank.Ace);
            var stack = new Stack(new List<Card> {expectedCard});

            CollectionAssert.AreEqual(stack, new List<Card> {expectedCard});
        }
    }
}