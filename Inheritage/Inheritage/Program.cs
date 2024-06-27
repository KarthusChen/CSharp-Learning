namespace Inheritage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.makeSound();

            Corgi corgi = new Corgi();
            corgi.makeSound();

            Cat cat = new Cat();
            cat.makeSound();

            Console.ReadLine();
        }
    }

    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }

        public virtual void makeSound()
        {
            Console.WriteLine("Sound");
        }
    }

    class Dog:Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Barking...");
        }

    }

    class Cat : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Meowing...");
        }
    }



    class Corgi : Dog
    {
        public void 摇屁股()
        {
            Console.WriteLine("摇屁股ing...");
        }
    }


}
