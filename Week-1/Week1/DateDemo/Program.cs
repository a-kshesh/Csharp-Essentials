using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Date a = new Date(2018, 6, 8);
            Console.WriteLine($"Date {a}");
            a.add(1);
            Console.WriteLine($"add days{a}");
            a.add(2, 2);
            Console.WriteLine($"add days and months{a}");
            a.add(a);
            Console.WriteLine($"add days and months and years{a}");
        }

        
    }

    class Date
    {
        private int year;
        private int month;
        private int day;


        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public override string ToString()
        {
            return $"{day}-{month}-{year}";
        }

        public void add(int day)
        {
            day += day;
        }
        public void add(int month, int day)
        {
            this.day += day;
            this.month += month;
        }

        public void add(Date other)
        {
            this.day += other.day;
            this.month += other.month;
            this.year += other.year;

        }


    }
}