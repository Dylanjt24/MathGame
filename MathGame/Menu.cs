namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new();

        // internal so program.cs can access it
        internal void ShowMenu(string? name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your maths game. That's great you're working on improving yourself. \n");
            Console.WriteLine("Press enter to show menu.");
            Console.ReadLine();

            // Keeps track of whether the game has ended or not
            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
            V - View Previous Games
            A - Addition
            S - Subtraction
            M - Multiplication
            D - Division
            Q - Quit the program");
                Console.WriteLine("------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game");
                        break;
                    case "q":
                        // set isGameOn to false when player quits so it breaks the do-while loop
                        isGameOn = false;
                        Helpers.Quit();
                        break;
                    default:
                        Console.WriteLine("Invalid input.\n");
                        break;
                }
            } while (isGameOn);
        }
    }
}
