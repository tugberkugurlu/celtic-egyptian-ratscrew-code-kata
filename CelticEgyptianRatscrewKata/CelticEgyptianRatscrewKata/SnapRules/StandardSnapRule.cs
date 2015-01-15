namespace CelticEgyptianRatscrewKata.SnapRules
{
    public class StandardSnapRule : IRule
    {
        public bool CanSnap(Stack stack)
        {
            Rank? previous = null;
            foreach (var card in stack)
            {
                if (card.Rank == previous) return true;
                previous = card.Rank;
            }
            return false;
        }
    }
}