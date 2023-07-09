using Math_Game;

var menu = new Menu();
string name = GetName();
var games = new List<string>();
string GetName()
{
    Console.WriteLine("Enter Name: ");
    string? name = Console.ReadLine();
    return name;
};

menu.ShowMenu(name);
