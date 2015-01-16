using CelticEgyptianRatscrewKata.SnapRules;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class SandwichSnapRuleTests
    {
        [Test]
        public void ShouldFailOnEmptyStack()
        {
            var rule = new SandwichSnapRule();
            var stack = Stack.Empty();
            Assert.That(rule.CanSnap(stack), Is.False);
        }
    }
}