using System.Linq.Expressions;

namespace FortuneTeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Random random = new Random();
            int fortune = random.Next(1, 4);
            switch (fortune)
            {
                case 1:
                    Console.WriteLine("Yes");
                    break;
                case 2:
                    Console.WriteLine("Maybe");
                    break;
                case 3:
                    Console.WriteLine("No");
                    break;
                default:
                    Console.WriteLine("Who the hell knows");
                        break;
            }

           

        }
    }
}
