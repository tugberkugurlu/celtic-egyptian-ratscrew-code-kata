using System.Collections.Generic;
using CelticEgyptianRatscrewKata.SnapRules;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class StandardSnapRuleTests
    {
        [Test]
        public void ShouldFailOnEmptyStack()
        {
            var stack = Stack.Empty();

            var rule = new StandardSnapRule();
            Assert.That(rule.CanSnap(stack), Is.False);
        }

        [Test]
        public void ShouldFailIfNoPairFound()
        {
            var stack = new Stack(new List<Card>
            {
                new Card(Suit.Clubs, Rank.Ace),
                new Card(Suit.Clubs, Rank.Two),
            });

            var rule = new StandardSnapRule();
            Assert.That(rule.CanSnap(stack), Is.False);
        }
    }
}