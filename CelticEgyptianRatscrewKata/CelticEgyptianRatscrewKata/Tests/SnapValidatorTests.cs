using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class SnapValidatorTests
    {
        [Test]
        public void ShouldNotBeSnappableIfAllRulesReturnFalse()
        {
            var ruleMock = new Mock<IRule>();
            ruleMock.Setup(x => x.CanSnap(It.IsAny<Stack>())).Returns(false);
            var rules = new List<IRule> { ruleMock.Object, ruleMock.Object };

            var stack = new Stack(Enumerable.Empty<Card>());
            var snapValidator = new SnapValidator();
            bool canSnap = snapValidator.CanSnap(stack, rules);

            Assert.That(canSnap, Is.False);
        }
    }
}