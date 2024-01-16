using static System.Formats.Asn1.AsnWriter;

var date = DateTime.UtcNow;
var games = new List<string>();
string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name:");
    var name = Console.ReadLine();
    return name;
}

void Menu(string? name)
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

// Get and show scores of previous games
void GetGames()
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
void AddToHistory(int score, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType}: Score = {score}");
}

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;
    int firstNumber;
    int secondNumber;

    for(int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1,9);
        secondNumber = random.Next(1,9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

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
    AddToHistory(score, "Addition");
    Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
    Console.ReadLine();
}

void SubtractionGame(string message)
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
    AddToHistory(score, "Subtraction");
    Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
    Console.ReadLine();
}

void MultiplicationGame(string message)
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
    AddToHistory(score, "Multiplication");
    Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
    Console.ReadLine();
}

void DivisionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        // Get division numbers and assign first/second numbers to corresponding results array index
        var divisionNumbers = GetDivisionNumbers();
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
    AddToHistory(score, "Division");
    Console.WriteLine($"Game over. Your final score is {score}. Press enter to return to the main menu.");
    Console.ReadLine();
}

// Get numbers for division game
int[] GetDivisionNumbers()
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

void Quit()
{
    Console.WriteLine("See ya later!");
}

