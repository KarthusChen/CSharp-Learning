namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int?age = null;
            Console.WriteLine(age);
            int MyAge = 19;


            if (age.HasValue)
            {
                Console.WriteLine("Age is "+age.Value);
            }
            else
            {
                int sum= age.Value+MyAge;
                Console.WriteLine(sum);
            }


            Console.ReadLine();
        }
    }
}
