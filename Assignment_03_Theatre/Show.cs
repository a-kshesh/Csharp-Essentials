using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Theatre
{
    class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }

        public Show(Movie movie, Day day, double price, Time time)
        {
            this.Day = day;
            this.Movie = movie;
            this.Price = price;
            this.Time = time;
        }

        public override string ToString()
        {
            return $"{Day} || {Time} || ${Price} || {Movie}";
        }
    }
}
