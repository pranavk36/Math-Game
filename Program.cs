string name = GetName();
string GetName()
{
    Console.WriteLine("Enter Name: ");
    string? name = Console.ReadLine();
    return name;
};

Menu(name);
void Menu(string name)
{
    Console.WriteLine($"Hello {name}! We are learning C# basics \n");
    Console.WriteLine("\n");
    Console.WriteLine("This is a Math Game, To learn and understand Core C# Concepts \n");
    Console.WriteLine(@$"Please Select an Option: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quitting The Game");

    var GameSelected = Console.ReadLine();

    switch (GameSelected)
    {
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
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid");
            break;
    }
};

void Additiongame(string message)
{
    Console.WriteLine(message);
    var Random = new Random();
    var score = 0;
    int num1;
    int num2;
    for (int i = 0; i < 5; i++)
    {

        num1 = Random.Next(1, 50);
        num2 = Random.Next(1, 50);

        Console.WriteLine($"{num1} + {num2}");
        var result = Console.ReadLine();

      if (int.Parse(result) == num1 + num2)
        {
            System.Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            System.Console.WriteLine("Wrong...");
        }
        if (i == 4) { System.Console.WriteLine($"Game Over!! Your Score is {score}"); }
    }




};
void SubtractionGame(string message)
{

    Console.WriteLine(message);
    var Random = new Random();
    var score = 0;
    int num1;
    int num2;
    for (int i = 0; i < 5; i++)
    {

        num1 = Random.Next(1, 50);
        num2 = Random.Next(1, 50);

        Console.WriteLine($"{num1} - {num2}");
        var result = Console.ReadLine();

        if (int.Parse(result) == num1 - num2)
        {
            System.Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            System.Console.WriteLine("Wrong...");
        }
        if (i == 4) { System.Console.WriteLine($"Game Over!! Your Score is {score}"); }
    }
};
void MultiplicationGame(string message)
{
    Console.WriteLine(message);
    var Random = new Random();
    var score = 0;
    int num1;
    int num2;
    for (int i = 0; i < 5; i++)
    {

        num1 = Random.Next(1, 50);
        num2 = Random.Next(1, 50);

        Console.WriteLine($"{num1} * {num2}");
        var result = Console.ReadLine();

        if (int.Parse(result) == num1 * num2)
        {
            System.Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            System.Console.WriteLine("Wrong...");
        }
        if (i == 4) { System.Console.WriteLine($"Game Over!! Your Score is {score}"); }
    }
};
void DivisionGame(string message) { };