using System.Linq;

namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class DarkQueenSnapRule : IRule
    {
        public bool CanSnap(Stack stack)
        {
            var topCard = stack.FirstOrDefault();
            return topCard != null && topCard.Equals(new Card(Suit.Spades, Rank.Queen));
        }
    }
}