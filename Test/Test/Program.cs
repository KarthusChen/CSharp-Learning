namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int result;
            bool success = int.TryParse(a, out result);
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
