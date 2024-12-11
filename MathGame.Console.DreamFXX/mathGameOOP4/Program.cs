using mathGameOOP4; // Převedeno refaktoringem na příkazy nejvyšší úrovně.


var menu = new Menu(); // Spojí třídu Menu s tímto celým projektem.

var date = DateTime.UtcNow;

var games = new List<string>();

string name = GetName();

menu.ShowMenu(name, date); // Odkaz na třídu Menu - void ShowMenu.

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}


