using System;

namespace CelticEgyptianRatscrewKata.Game
{
    public interface IGameState
    {
        Cards Stack { get; }

        /// <summary>
        /// Add the given player to the game with the given deck.
        /// </summary>
        /// <exception cref="ArgumentException">If the given player already exists</exception>
        void AddPlayer(string playerId, Cards deck);

        /// <summary>
        /// Play the top card of the given player's deck.
        /// </summary>
        void PlayCard(string playerId);

        /// <summary>
        /// Wins the stack for the given player.
        /// </summary>
        void WinStack(string playerId);

        bool HasCards(string playerId);
        void Clear();
    }
}