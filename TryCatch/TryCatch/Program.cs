namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 2;
            var sum=0;
            try
            {
                sum = num2 / num1;
                Console.WriteLine(sum);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
