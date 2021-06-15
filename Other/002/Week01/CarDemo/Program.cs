using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(2015, "Honda", "Civic", 15878, false);
            Console.WriteLine(c);
        }
    }
    class Car
    {
        int year;
        string manufacturer;
        string model;
        double price;
        bool isDrivable;

        public Car(int year, string manufacturer, string model,
            double price, bool isDrivable = true)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = price;
        }
        public override string ToString()
        {
            return $"{manufacturer} {model} {year} {price:c} {(isDrivable ? "Drivable" : "Not drivable")}";
        }
    }
}
