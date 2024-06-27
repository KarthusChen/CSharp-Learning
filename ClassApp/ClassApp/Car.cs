using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    internal class Car
    {
        public static int NumberOfCars=0;

        private string _model="";
        private string _brand="";
        private bool _isLuxury;

        public Car() 
        {
            Model = "Not Entered Yet";
            Brand = "Not Entered Yet";
            IsLuxury = false;
            Console.WriteLine($"Yeah! A {Brand} {Model} has been created!");
            NumberOfCars++;
        }

        public Car(string model,string brand,bool isLuxury) 
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            Console.WriteLine($"Yeah! A {Brand} {Model} has been created!");
            NumberOfCars++;
        }

        public string Model { get => _model; set => _model = value; }
        public string Brand {
            get
            {
                if (_isLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else
                {
                    return _brand;
                }
            }

            set
            {   if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You Entered Nothing");
                }
                else
                {
                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
    }
}
