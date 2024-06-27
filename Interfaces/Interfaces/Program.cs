namespace Interfaces
{
    public interface IAnimal
    {
        void MakeSound();

        void Eat(string food);
    }

    class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Barking");
        }
        public void Eat(string food)
        {
            Console.WriteLine("Eating" + food);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();

            Console.ReadLine();
        }
    }
}
