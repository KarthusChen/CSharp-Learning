// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Something:");


double userInput1= double.Parse(Console.ReadLine());
double userInput2= double.Parse(Console.ReadLine());
double sum= userInput2 + userInput1;
sum = Math.Round(sum, 2);

Console.WriteLine($"The sum of those two numbers is:{sum}");

Console.ReadKey();