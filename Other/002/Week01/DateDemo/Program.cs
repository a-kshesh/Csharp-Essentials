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
            Date d1 = new Date(6, 9, 2019);
            Console.WriteLine(d1);
            int days = 10;
            Console.WriteLine($"Adding {days} days");
            d1.Add(days);
            Console.WriteLine(d1);
            int months = 3;
            Console.WriteLine($"Adding {days} days and {months} months");
            d1.Add(months, days);
            Console.WriteLine(d1);
            int years = 5;
            Console.WriteLine($"Adding {days} days and {months} months and {years} years");
            Date toAdd = new Date(days, months, years);
            d1.Add(toAdd);
            Console.WriteLine(d1);
            
        }
    }
    class Date
    {
        static string[] MONTHS = "January February March April May June July August September October November December".Split();
        int day, month, year;
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void Add(int days)
        {
            day += days;
            Normalize();
        }
        public void Add(int months, int days)
        {
            month += months;
            day += days;
            Normalize();
        }    
        public void Add(Date other)
        {
            int daysToAdd = other.day;
            int monthsToAdd = other.month;
            day += daysToAdd;
            month += monthsToAdd;
            year += other.year;
            Normalize();
        }
        private void Normalize()
        {
            while (day > 30)
            {
                day -= 30;
                month++;
            }
            while (month > 12)
            {
                month -= 12;
                year++;
            }
        }
        public override string ToString()
        {
            //return $"{day} {MONTHS[month-1].Substring(0,3).ToUpper()}, {year}";
            return $"{month:d2}/{day:d2}/{year}";
        }
    }
}
