using System.Linq;

namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class DarkQueenSnapRule : IRule
    {
        private static readonly Card s_QueenOfSpades = new Card(Suit.Spades, Rank.Queen);

        public bool CanSnap(Stack stack)
        {
            var topCard = stack.FirstOrDefault();
            return topCard != null && topCard.Equals(s_QueenOfSpades);
        }
    }
}