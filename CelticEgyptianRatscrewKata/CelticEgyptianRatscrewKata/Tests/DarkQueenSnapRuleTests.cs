using CelticEgyptianRatscrewKata.SnapRules;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class DarkQueenSnapRuleTests
    {
        [Test]
        public void ShouldFailOnEmptyStack()
        {
            var rule = new DarkQueenSnapRule();
            var stack = Stack.Empty();
            Assert.That(rule.CanSnap(stack), Is.False);
        }
    }
}