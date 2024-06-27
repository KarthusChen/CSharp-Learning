namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> employees = new Dictionary<int,string>();

            employees.Add(101, "John");
            employees.Add(102, "Bob");

            Console.WriteLine(employees[101]);

            foreach(KeyValuePair<int,string> employee in employees)
            {
                Console.WriteLine($"The ID is: {employee.Key} " +
                    $"and the name is: {employee.Value}");
            }

            Console.ReadLine();
        }
    }
}
