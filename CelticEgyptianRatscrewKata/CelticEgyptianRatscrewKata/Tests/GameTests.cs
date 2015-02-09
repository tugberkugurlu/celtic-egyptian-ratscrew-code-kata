using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CelticEgyptianRatscrewKata.Tests
{
    public class GameTests
    {
        [Test]
        public void Game_Ctor_Should_Throw_ArgumentException_If_Players_Count_Is_Less_Than_2()
        {
            var players = new[] {new Player("Mark")};
            ArgumentException exception = Assert.Throws<ArgumentException>(() => new Game(players));
            Assert.AreEqual("players", exception.ParamName);
        }
    }
}
