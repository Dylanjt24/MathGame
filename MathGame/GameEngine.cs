using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            // Initialize variables for generating addition numbers
            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                // Print message based on whether guess is correct or not
                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("That's the correct asnwer! Press enter for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. The correct answer was " + (firstNumber + secondNumber) + ".\nPress enter for the next question.");
                    Console.ReadLine();
                }
            }
            // Add the game and score to game history
           Helpers.AddToHistory(score, GameType.Addition);
            Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
            Console.ReadLine();
        }

        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("That's the correct asnwer! Press enter for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. The correct answer was " + (firstNumber - secondNumber) + ".\nPress enter for the next question.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Subtraction);
            Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
            Console.ReadLine();
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;
            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("That's the correct asnwer! Press enter for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. The correct answer was " + (firstNumber * secondNumber) + ".\nPress enter for the next question.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Multiplication);
            Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
            Console.ReadLine();
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                // Get division numbers and assign first/second numbers to corresponding results array index
                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("That's the correct asnwer! Press enter for the next question.");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. The correct answer was " + (firstNumber / secondNumber) + ".\nPress enter for the next question.");
                    Console.ReadLine();
                }
            }
            Helpers.AddToHistory(score, GameType.Division);
            Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
            Console.ReadLine();
        }

    }
}
