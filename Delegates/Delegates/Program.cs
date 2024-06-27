namespace Delegates
{

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    internal class Program
    {

        public delegate bool FilterDelegate(Person P);

        static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Aiden", Age = 18 };
            Person p2 = new Person() { Name = "Jorge", Age = 12 };
            Person p3 = new Person() { Name = "Chris", Age = 20 };
            Person p4 = new Person() { Name = "Chen", Age = 19 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            DisplayPeople("Kids", people, isMinor);
            DisplayPeople("Adults",people, isAdult);
            DisplayPeople("Seniors", people,isSenior);



            FilterDelegate filter = delegate (Person person)
            {
                return person.Age >= 20 && person.Age <= 30;
            };

            DisplayPeople("MidAge People",people, filter);

            DisplayPeople("All", people, delegate(Person p ) {return true; });

            DisplayPeople("Name has A inside:", people, p => p.Name.Contains("A"));

            Console.ReadLine();
        }
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"The name of the person is:{person.Name}\n" +
                    $"Age is:{person.Age}\n");
                }

            }
        }
        static bool isMinor(Person person)
        {
            return person.Age < 18;
        }

        static bool isAdult(Person person)
        {
            return person.Age >= 18;
        }
        static bool isSenior(Person person)
        {
            return person.Age >= 60;
        }


    }
}
