using System;
using System.Collections.Generic;
using CelticEgyptianRatscrewKata.Game;

namespace ConsoleBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new GameFactory().Create();

            var playerInfos = GetPlayerInfoFromUser();

            foreach (var playerInfo in playerInfos)
            {
                
            }
        }

        private static IEnumerable<PlayerInfo> GetPlayerInfoFromUser()
        {
            bool again;
            do
            {
                Console.Write("Enter player name: ");
                var playerName = Console.ReadLine();
                Console.Write("Enter play card key: ");
                var playCardKey = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Write("Enter snap key: ");
                var snapKey = Console.ReadKey().KeyChar;
                Console.WriteLine();
                yield return new PlayerInfo(playerName, playCardKey, snapKey);

                Console.Write("Create another player? (y|n): ");
                var createPlayerKey = Console.ReadKey();
                Console.WriteLine();
                again = createPlayerKey.KeyChar.Equals('y');
            } while (again);
        }
    }
}
