using Math_Game.Models;

namespace Math_Game
{
    public class Helpers
    {
        internal static List<Game> games = new List<Game>();
        internal static void GetGames()
        {
            foreach (var game in games)
            {
                System.Console.WriteLine("Games you've Played: ");
                Console.WriteLine($"{game.Score} {game.Type}");
                System.Console.WriteLine("Press Any Key to return to the Main Menu");
                Console.ReadLine();
            };
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game { Score = gameScore, Type = gameType });
        }

        internal static int[] getDivisionNumbers()
        {
            var Random = new Random();
            var num1 = Random.Next(1, 99);
            var num2 = Random.Next(1, 50);
            var result = new int[2];
            while (num1 % num1 != 0)
            {
                num1 = Random.Next(1, 99);
                num2 = Random.Next(1, 99);
            };
            result[0] = num1;
            result[1] = num2;


            return result;
        }
    }
}