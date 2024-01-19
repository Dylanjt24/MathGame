using MathGame;
using static System.Formats.Asn1.AsnWriter;

var menu = new Menu();
var date = DateTime.UtcNow;
var games = new List<string>();
string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name:");
    var name = Console.ReadLine();
    return name;
}

