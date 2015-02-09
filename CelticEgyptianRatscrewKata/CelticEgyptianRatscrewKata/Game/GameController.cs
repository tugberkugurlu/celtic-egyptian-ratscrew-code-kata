using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CelticEgyptianRatscrewKata.SnapRules;

namespace CelticEgyptianRatscrewKata.Game
{
    /// <summary>
    /// Controls a game of Celtic Egyptian Ratscrew.
    /// </summary>
    public class GameController
    {
        private readonly SnapValidator m_SnapValidator;
        private readonly IList<IPlayer> m_Players;
        private readonly IEnumerable<IRule> m_Rules;
        private readonly GameState m_GameState;

        public GameController(SnapValidator snapValidator, IEnumerable<IRule> rules)
        {
            m_Players = new List<IPlayer>();
            m_GameState = new GameState();
            m_SnapValidator = snapValidator;
            m_Rules = rules;
        }

        public bool AddPlayer(IPlayer player)
        {
            if (m_Players.Any(x => x.Name == player.Name)) return false;

            m_Players.Add(player);
            m_GameState.AddPlayer(player.Name, Cards.Empty());
            return true;
        }

        public void PlayCard(IPlayer player)
        {
            if (m_GameState.HasCards(player.Name))
            {
                m_GameState.PlayCard(player.Name);
            }
        }
    }
}
