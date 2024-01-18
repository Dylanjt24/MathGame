using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Menu
    {
        internal void ShowMenu(string? name)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your maths game. That's great you're working on improving yourself. \n");

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
                        GetGames();
                        break;
                    case "a":
                        AdditionGame("Addition game");
                        break;
                    case "s":
                        SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        DivisionGame("Division game");
                        break;
                    case "q":
                        // set isGameOn to false when player quits so it breaks the do-while loop
                        isGameOn = false;
                        Quit();
                        break;
                    default:
                        Console.WriteLine("Invalid input.\n");
                        break;
                }
            } while (isGameOn);
        }
    }
}
