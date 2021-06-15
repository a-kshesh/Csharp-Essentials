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
            Car a = new Car(1990, "suzuki",80000,"maruti800",false);
            Car b = new Car(2000, "toyota", 80000, "maruti800", true);
            Car c = new Car(2010, "honda", 80000, "maruti800", false);
            Car d = new Car(2019, "Audi", 80000, "maruti800", true);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
    class Car
    {
        private int year;
        private string manufacturer;
        private string model;
        private bool isDrivable;
        private double price;

        public Car(int year, string manufacturer, double price, string model, bool isDrivable=true)
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = price;
        }

        public override string ToString()
        {
            return $"year:{year},manufacturer{manufacturer},model:{model},isDrivable{isDrivable},Price: {price}";
        }

    }

    
}
