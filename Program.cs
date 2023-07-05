string name = GetName();
var games = new List<string>();
string GetName()
{
    Console.WriteLine("Enter Name: ");
    string? name = Console.ReadLine();
    return name;
};

Menu(name);
void Menu(string name)
{
    bool IsGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine($"Hello {name}! We are learning C# basics \n");
        Console.WriteLine("\n");
        Console.WriteLine("This is a Math Game, To learn and understand Core C# Concepts \n");
        Console.WriteLine(@$"Please Select an Option: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quitting The Game
V - View Game History");

        var GameSelected = Console.ReadLine();

        switch (GameSelected)
        {
            case "v":
                GetGames();
                break;
            case "a":
                Additiongame("Addition Selected");
                break;
            case "s":
                SubtractionGame("Subtraction Selected");
                break;
            case "m":
                MultiplicationGame("MultiPlication Selected");
                break;
            case "d":
                DivisionGame("Division Selected");
                break;
            case "q":
                Console.WriteLine("Good Bye");
                IsGameOn = false;
                Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    } while (IsGameOn);

}

void GetGames()
{
    foreach (var game in games)
    {
        System.Console.WriteLine("Games you've Played: ");
        Console.WriteLine(games);
        System.Console.WriteLine("Press Any Key to return to the Main Menu");
        Console.ReadLine();
    };
};

void Additiongame(string message)
{
    var Random = new Random();
    var score = 0;
    int num1;
    int num2;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        num1 = Random.Next(1, 50);
        num2 = Random.Next(1, 50);

        Console.WriteLine($"{num1} + {num2}");
        var result = Console.ReadLine();

        if (int.Parse(result) == num1 + num2)
        {
            System.Console.WriteLine("Correct!");
            score++;
            Console.ReadKey();
        }
        else
        {
            System.Console.WriteLine("Wrong...");
            Console.ReadKey();
        }
        if (i == 4) { System.Console.WriteLine($"Game Over!! Your Score is {score}"); }
    }
    AddToHistory(score, "Addition");
};

void SubtractionGame(string message)
{

    var Random = new Random();
    var score = 0;
    int num1;
    int num2;
    try
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            num1 = Random.Next(1, 50);
            num2 = Random.Next(1, 50);

            Console.WriteLine($"{num1} - {num2}");
            var result = Console.ReadLine();

            if (int.Parse(result) == num1 - num2)
            {
                System.Console.WriteLine("Correct!");
                score++;
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("Wrong...");
                Console.ReadKey();
            }
            if (i == 4) { System.Console.WriteLine($"Game Over!! Your Score is {score}"); }
        }
        AddToHistory(score, "Subtraction");
    }
    catch (System.FormatException)
    {
        System.Console.WriteLine("Invalid Input");
    };

};

void MultiplicationGame(string message)
{

    var Random = new Random();
    var score = 0;
    int num1;
    int num2;
    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        num1 = Random.Next(1, 50);
        num2 = Random.Next(1, 50);

        Console.WriteLine($"{num1} * {num2}");
        var result = Console.ReadLine();

        if (int.Parse(result) == num1 * num2)
        {
            System.Console.WriteLine("Correct!");
            score++;
            Console.ReadKey();
        }
        else
        {
            System.Console.WriteLine("Wrong...");
            Console.ReadKey();
        }
        if (i == 4) { System.Console.WriteLine($"Game Over!! Your Score is {score}"); }
    }
    AddToHistory(score, "Multiplication");
};

void DivisionGame(string message)
{
    var score = 0;
    try
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine(message);
            var divisionNumbers = getDivisionNumbers();
            var num1 = divisionNumbers[0];
            var num2 = divisionNumbers[1];
            System.Console.WriteLine($"{num1} / {num2}");
            var result = Console.ReadLine();
            if (int.Parse(result) == num1 / num2)
            {
                System.Console.WriteLine("Correct!");
                score++;
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("Wrong...");
                Console.ReadKey();
            }
            if (i == 4) { System.Console.WriteLine($"Game Over!! Your Score is {score}"); }
        }
        
        
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Type error. just use normal no.s");
    }
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{gameType}: Score - {gameScore}");
};

int[] getDivisionNumbers()
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
};

