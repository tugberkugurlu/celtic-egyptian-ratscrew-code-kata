using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Dealer
    {
        public List<Cards> Deal(int numberOfHands, Cards deck)
        {
            var hands = new List<Cards>();

            for (int i = 0; i < numberOfHands; i++)
            {
                hands.Add(Cards.Empty());
            }

            while (deck.HasCards)
            {
                hands.ElementAt(0).AddToTop(deck.Pop());
            }

            return hands;
        }
    }
}