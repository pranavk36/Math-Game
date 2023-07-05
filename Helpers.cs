namespace Math_Game
{
    public class Helpers
    {
        static List<string> games = new();
       internal static void GetGames()
{
    foreach (var game in games)
    {
        System.Console.WriteLine("Games you've Played: ");
        Console.WriteLine(games);
        System.Console.WriteLine("Press Any Key to return to the Main Menu");
        Console.ReadLine();
    };
}


internal static void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{gameType}: Score - {gameScore}");
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