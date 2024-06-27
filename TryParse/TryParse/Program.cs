Console.WriteLine("Give me a number:");

Random random = new Random();
int randomNumber = random.Next(1,11);

string inputString= Console.ReadLine();
int num1=0;

bool isNumber = int.TryParse(inputString, out num1);

num1++;
Console.WriteLine("User entered number +1 = " + num1);

Console.ReadKey();