namespace MathGame
{
    internal class Helpers
    {
        // Get and show scores of previous games
        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("Press enter to return to the main menu");
            Console.ReadLine();
        }

        // Add the datetime, game type, and score to game history list
        internal static void AddToHistory(int score, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: Score = {score}");
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
