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

    public class SandwichSnapRule : IRule
    {
        public bool CanSnap(Stack stack)
        {
            return true;
        }
    }
}