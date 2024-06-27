Console.WriteLine("Welcome to the Adventure Game");
Console.WriteLine("Enter your character's name: ");
string playerName = Console.ReadLine();

Console.WriteLine("Choose your character type:(Warrior, Wizard, Archer");
string characterType= Console.ReadLine();

Console.WriteLine($"You,{playerName}the {characterType}find yourself at the edge of a dark forest.");
Console.WriteLine("Do you enter the forest or camp outside?");

Console.ReadKey();