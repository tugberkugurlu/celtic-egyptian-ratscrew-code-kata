using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelticEgyptianRatscrewKata
{
    public class Game
    {
        private readonly IList<Player> _playersList;

        public Game(IEnumerable<Player> players)
        {
            if (players == null)
            {
                throw new ArgumentNullException("players");
            }

            _playersList = players.ToList();
            if (_playersList.Count < 2)
            {
                throw new ArgumentException("Game cannot be played with less than 2 players.", "players");
            }
        }
    }

    public class Player
    {
        private readonly string _name;

        public Player(string name)
        {
            if (name == null) throw new ArgumentNullException("name");

            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
