using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        static List<Game> games = new();

        // Get and show scores of previous games
        internal static void PrintGames()
        {
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
        internal static void AddToHistory(int score, string gameType)
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
    }
}
