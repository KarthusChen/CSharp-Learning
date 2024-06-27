namespace ListIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list = new List<int> {10,23,3,4,5,56,3,89,1,2,25 };


            Predicate<int> isGreaterthan = x => x >= 10;

            List<int>GreaterEqualTen=list.FindAll(isGreaterthan);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            foreach (int i in GreaterEqualTen)
            {
                Console.WriteLine(i); 
            }

            Console.ReadLine();

            

        }

    }
}
