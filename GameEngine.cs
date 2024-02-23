
namespace Math_Game
{
    public class GameEngine
    {
         internal void Additiongame(string message)
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
                    System.Console.WriteLine("Correct! Bravo!!!");
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
            Helpers.AddToHistory(score, "Addition");
        }

        internal void SubtractionGame(string message)
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
                Helpers.AddToHistory(score, "Subtraction");
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("Invalid Input");
            };

        }

        internal void MultiplicationGame(string message)
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
            Helpers.AddToHistory(score, "Multiplication");
        }

        internal void DivisionGame(string message)
        {
            var score = 0;
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);
                    var divisionNumbers = Helpers.getDivisionNumbers();
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

                Helpers.AddToHistory(score, "Division");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Type error. just use normal no.s");
            }
        }

    }
}
