using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class GameTests
    {
        [Test]
        public void Game_Ctor_Should_Throw_ArgumentException_If_Players_Count_Is_Less_Than_2()
        {
            var players = new[] {new Player("Mark")};
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Game(players, new Shuffler(), new Dealer()));
            Assert.AreEqual("players", exception.ParamName);
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void GameUsesDealerWhenDealingOutCards(int playerCount)
        {
            var players = Enumerable.Range(1, playerCount).Select(i => new Player("Player " + i)).ToList();
            var dealer = new Mock<IDealer>();
            dealer.Setup(x => x.Deal(playerCount, It.IsAny<Cards>())).Returns(new Cards[playerCount].ToList());
            var game = new Game(players, new NullShuffler(), dealer.Object);
            game.Deal();
            dealer.Verify(x => x.Deal(playerCount, It.IsAny<Cards>()), Times.Once());
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void GameGivesCardsToPlayersThatDealerDealt(int playerCount)
        {
            var players = Enumerable.Range(1, playerCount).Select(i => new Player("Player " + i)).ToList();
            var dealer = new Mock<IDealer>();
            var dealtCards = Enumerable.Range(1, playerCount).Select(x => new Cards(new[] {new Card(Suit.Clubs, (Rank) x)})).ToList();
            dealer
                .Setup(x => x.Deal(playerCount, It.IsAny<Cards>()))
                .Returns(dealtCards);
            var game = new Game(players, new NullShuffler(), dealer.Object);
            game.Deal();
            players.Zip(dealtCards, (player, hand) => CollectionAssert.AreEqual(hand, player.Hand));
        }

        public class NullShuffler : IShuffler
        {
            public Cards Shuffle(Cards deck)
            {
                return deck;
            }
        }
    }
}
