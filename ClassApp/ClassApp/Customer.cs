using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Customer
    {
        public static int NextID = 0;
        //readonly variables can only be initialized by the constructor
        private readonly int _id;

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }


        public Customer()
        {
            _id = NextID++;
            Name = "Piece of Shit";
            Address = "Piece of Shit";
            ContactNumber = "Piece of Shit";
        }

        public Customer(string name, string address, string contactNumber)
        {
            _id=NextID++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public Customer(string name)
        {
            _id=NextID++;
            Name=name;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Details of Customer: \n" +
                $"Name:{Name}\n" +
                $"Address:{Address}\n" +
                $"ContactNumber:{ContactNumber} \n" +
                $"ID:{_id}");
        }

    }
}
