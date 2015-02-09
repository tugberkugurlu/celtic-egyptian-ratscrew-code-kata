using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelticEgyptianRatscrewKata
{
    public class Game
    {
        private readonly IShuffler _shuffler;
        private readonly IDealer _dealer;
        private readonly IList<Player> _playersList;

        public Game(IEnumerable<Player> players, IShuffler shuffler, IDealer dealer)
        {
            _shuffler = shuffler;
            _dealer = dealer;
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

        public void Deal()
        {
            var deck = Cards.Deck();
            var shuffledDeck = _shuffler.Shuffle(deck);
            var hands = _dealer.Deal(_playersList.Count, shuffledDeck);
            _playersList.Zip(hands, (player, hand) => player.DealHand(hand));
        }
    }

    public class Player
    {
        private readonly string _name;
        private Cards _hand;

        public Player(string name)
        {
            if (name == null) throw new ArgumentNullException("name");

            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public Cards Hand
        {
            get { return _hand; }
        }

        public void DealHand(Cards hand)
        {
            _hand = hand;
        }
    }
}
