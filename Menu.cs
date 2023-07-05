
namespace Math_Game
{
    public class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu(string name)
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
                        Helpers.GetGames();
                        break;
                    case "a":
                        engine.Additiongame("Addition Selected");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction Selected");
                        break;
                    case "m":
                        engine.MultiplicationGame("MultiPlication Selected");
                        break;
                    case "d":
                        engine.DivisionGame("Division Selected");
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

    }
}