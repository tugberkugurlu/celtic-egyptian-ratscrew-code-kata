using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CelticEgyptianRatscrewKata
{
    public class Cards : IEnumerable<Card>
    {
        private readonly List<Card> m_Cards;

        public Cards(IEnumerable<Card> cards)
        {
            m_Cards = new List<Card>(cards);
        }

        public IEnumerator<Card> GetEnumerator()
        {
            return m_Cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static Cards Empty()
        {
            return new Cards(Enumerable.Empty<Card>());
        }
    }
}