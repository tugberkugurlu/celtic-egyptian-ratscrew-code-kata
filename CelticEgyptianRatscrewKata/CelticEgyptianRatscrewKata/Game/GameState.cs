using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CelticEgyptianRatscrewKata.Game
{
    /// <summary>
    /// Represents the state of the game at any point.
    /// </summary>
    public class GameState : IGameState
    {
        private readonly Cards m_Stack;
        private readonly IDictionary<string, Cards> m_Decks;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public GameState()
            : this(Cards.Empty(), new Dictionary<string, Cards>()) {}

        /// <summary>
        /// Constructor to allow setting the central stack.
        /// </summary>
        public GameState(Cards stack, IDictionary<string, Cards> decks)
        {
            m_Stack = stack;
            m_Decks = decks;
        }

        public Cards Stack { get {return new Cards(m_Stack);} }

        public void AddPlayer(string playerId, Cards deck)
        {
            if (m_Decks.ContainsKey(playerId)) throw new ArgumentException("Can't add the same player twice");
            m_Decks.Add(playerId, deck);
        }

        public void PlayCard(string playerId)
        {
            Debug.Assert(m_Decks.ContainsKey(playerId));
            Debug.Assert(m_Decks[playerId].Any());

            var topCard = m_Decks[playerId].Pop();
            m_Stack.AddToTop(topCard);
        }

        public void WinStack(string playerId)
        {
            Debug.Assert(m_Decks.ContainsKey(playerId));

            foreach (var card in m_Stack.Reverse())
            {
                m_Decks[playerId].AddToBottom(card);
            }

            ClearStack();
        }

        private void ClearStack()
        {
            while (m_Stack.HasCards)
            {
                m_Stack.RemoveCardAt(0);
            }
        }

        public bool HasCards(string playerId)
        {
            Debug.Assert(m_Decks.ContainsKey(playerId));
            return m_Decks[playerId].Any();
        }

        public void Clear()
        {
            ClearStack();
            m_Decks.Clear();
        }
    }
}
