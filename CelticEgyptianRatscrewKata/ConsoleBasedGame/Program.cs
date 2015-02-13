using CelticEgyptianRatscrewKata.Game;

namespace ConsoleBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameFactory().Create();

            var userInterface = new UserInterface();
            var playerInfos = userInterface.GetPlayerInfoFromUserLazily();

            foreach (var playerInfo in playerInfos)
            {
                game.AddPlayer(new Player(playerInfo.PlayerName));
            }

            game.StartGame(GameFactory.CreateFullDeckOfCards());

            char userInput;
            while (userInterface.TryReadUserInput(out userInput))
            {

            } 
        }
    }
}
