using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dream
{
    internal class Player
    {
        public string Name { get; set; }
        public double MaxHP { get; set; }
        public double CurrentHP { get; set; }
        public double Strenth { get; set; }

        public Player()
        {
            MaxHP = 100;
            CurrentHP = MaxHP;
            Console.WriteLine("Enter Your PlayerName:");
            Name = Console.ReadLine();
            Console.WriteLine($"Welcome to the Dream {Name}");
        }

        public void DisplayPlayer()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{CurrentHP}/{MaxHP}");
            Console.WriteLine("  O  ");
            Console.WriteLine("/ | \\");
            Console.WriteLine(" / \\");
        }
    }
}
