using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            //new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            //new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            //new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            //new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            //new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            //new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            //new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };

        // Get and show scores of previous games
        internal static void PrintGames()
        {
            // LINQ Query examples:
            //var gamesToPrint = games.Where(x => x.Type == GameType.Division);
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2024, 02, 10) && x.Score > 3);
            //var gamesToPrint = games.Where(x => x.Date > new DateTime(2024, 02, 10)).OrderByDescending(x => x.Score);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} pts");
            }
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("Press enter to return to the main menu");
            Console.ReadLine();
        }

        // Add the datetime, game type, and score to game history list
        internal static void AddToHistory(int score, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = score,
                Type = gameType
            });
        }

        // Get numbers for division game
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstNumber = random.Next(1, 101);
            var secondNumber = random.Next(1, 101);

            // Generate numbers until they are evenly divisible
            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 101);
                secondNumber = random.Next(1, 101);
            }
            int[] result = { firstNumber, secondNumber };

            return result;
        }

        internal static void Quit()
        {
            Console.WriteLine("See ya later!");
        }

        internal static string? ValidateResult(string result)
        {
            // Repeat readline if initial result was empty, or if it wasn't an integer
            // Using _ since I don't need an output
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                result = Console.ReadLine();
            }
            return result;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name:");
            var name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty.");
                name = Console.ReadLine();
            }

            return name;
        }

        internal static int[] ChooseDifficulty()
        {
            Console.Clear();
            var mathNums = new int[2];
            do
            {
                Console.WriteLine(@"Choose a difficulty:
    E - Easy
    M - Medium
    H - Hard
------------------------------------------");
                var difficulty = Console.ReadLine();
                mathNums[0] = 1;

                switch (difficulty.Trim().ToLower())
                {
                    case "e":
                        mathNums[1] = 10;
                        break;
                    case "m":
                        mathNums[1] = 50;
                        break;
                    case "h":
                        mathNums[1] = 100;
                        break;
                    default:
                        Console.WriteLine("Invalid input.\n");
                        break;
                }
                return mathNums;
            } while (true);

        }
    }
}
