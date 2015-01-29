using System.Collections.Generic;

namespace CelticEgyptianRatscrewKata
{
    public class Dealer
    {
        public List<Cards> Deal(int numberOfHands, Cards deck)
        {
            var hands = new List<Cards>();
            hands.Add(Cards.Empty());
            return hands;
        }
    }
}