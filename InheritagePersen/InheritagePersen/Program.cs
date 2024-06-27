using System.Threading.Tasks.Dataflow;

namespace InheritagePersen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager Annie = new Manager("Annie",5,"Security",123,3);
            


            Console.ReadKey();

        }


    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Console.WriteLine("Person Constructor called");
            Name = name;
            Age = age;
            Console.WriteLine($"Name:{Name} \nAge:{Age}");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name:{Name} \nAge:{Age}");
        }



    }

    class Employee : Person
    {
        public int ID { get; set; }
        public string jobTitle { get; set; }
        public Employee(string name, int age,string jobTitle, int ID):base(name,age)
        {
            Console.WriteLine("Employee constructor called");
            this.ID = ID;
            this.jobTitle = jobTitle;
            DisplayEmployeeInfo();
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Job Title:{jobTitle} ID:{ID}");
        }


    }

    class Manager : Employee
    {
        public int TeamSize {  get; private set; }

        public Manager(string name, int age, string jobTitle, int ID, int teamSize) 
            : base(name, age, jobTitle, ID)
        {
            Console.WriteLine("Manager Constructor called");
            TeamSize = teamSize;
            DisplayManagerInfo();
        }

        public void DisplayManagerInfo()
        {
            Console.WriteLine($"TeamSize:{TeamSize}");
        }

    }



}
