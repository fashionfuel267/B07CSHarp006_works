using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace B07CSHarp006_w01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "2013";
            car.Model = "BMW-2013";
            car.Price = 5000000; ;
            Console.WriteLine("First Car's information");
            car.Display();
            Car car1 = new Car();
            car1.Make = "2017";
            car1.Model = "X-Corola-2017";
            car1.Price = 15000000; ;
            Console.WriteLine("2nd  Car's information");
            car1.Display();
            Console.WriteLine("More expensive car");
            if (car1.Price > car.Price)
            {
               
                car1.Display();

            }
            else
            {
                car.Display();
            }
            var c = car.Price > car1.Price ? car : car1;
            c.Display();
            Console.ReadKey();
        }
    }
    public class Car
    {
        private string carMake, carModel;
        private double carPrice;
        public string Make
        {
            get { return carMake; }
            set { carMake = value; }
        }
        public string Model
        {
            get { return carModel; }
            set { carModel = value; }
        }
        public double Price
        {
            get { return carPrice; }
            set { carPrice = value; }

        }
        public void Display()
        {
            Console.Write($"Model:{Model},Car Make:{Make},Price:{Price}");
            Console.WriteLine();
        }

    }
}
