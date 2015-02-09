﻿using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public interface IDealer
    {
        List<Cards> Deal(int numberOfHands, Cards deck);
    }

    public class Dealer : IDealer
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
                for (int i = 0; i < numberOfHands && deck.HasCards; i++)
                {
                    hands.ElementAt(i).AddToTop(deck.Pop());
                }
            }

            return hands;
        }
    }
}