using System;
using System.Collections.Generic;
using CelticEgyptianRatscrewKata;
using CelticEgyptianRatscrewKata.Game;

namespace ConsoleBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameFactory().Create();

            var playerInfos = GetPlayerInfoFromUserLazily();

            foreach (var playerInfo in playerInfos)
            {
                game.AddPlayer(new Player(playerInfo.PlayerName));
            }

            game.StartGame(GameFactory.CreateFullDeckOfCards());

            ConsoleKeyInfo keyPress;
            do
            {
                keyPress = Console.ReadKey();
                Console.WriteLine();

            } while (keyPress.Key != ConsoleKey.Escape);

        }

        private static IEnumerable<PlayerInfo> GetPlayerInfoFromUserLazily()
        {
            bool again;
            do
            {
                Console.Write("Enter player name: ");
                var playerName = Console.ReadLine();
                var playCardKey = AskForKey("Enter play card key: ");
                var snapKey = AskForKey("Enter snap key: ");
                yield return new PlayerInfo(playerName, playCardKey, snapKey);

                var createPlayerKey = AskForKey("Create another player? (y|n): ");
                again = createPlayerKey.Equals('y');
            } while (again);
        }

        private static char AskForKey(string prompt)
        {
            Console.Write(prompt);
            var response = Console.ReadKey().KeyChar;
            Console.WriteLine();
            return response;
        }
    }
}
