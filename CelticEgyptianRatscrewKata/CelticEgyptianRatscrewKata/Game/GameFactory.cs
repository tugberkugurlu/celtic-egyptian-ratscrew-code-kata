using CelticEgyptianRatscrewKata.GameSetup;
using CelticEgyptianRatscrewKata.SnapRules;

namespace CelticEgyptianRatscrewKata.Game
{
    public class GameFactory
    {
        public GameController Create()
        {
            IRule[] rules =
            {
                new DarkQueenSnapRule(),
                new SandwichSnapRule(),
                new StandardSnapRule(),
            };
            return new GameController(new GameState(), new SnapValidator(rules), new Dealer(), new Shuffler());
        }
    }
}