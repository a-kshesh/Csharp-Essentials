using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Theatre
{
    class Theatre
    {
        public string Name { get; }

        private List<Show> shows;

        public Theatre(string name)
        {
            this.Name = name;
            this.shows = new List<Show> { };
        }

        public void AddShow(Show show)
        {
            this.shows.Add(show);
        }

        public void PrintShows()
        {
            foreach(Show s in shows)
            {
                Console.WriteLine(s);
            }
        }

        public void PrintShows(Genre genre)
        {
            foreach (Show s in shows)
            {
                if (s.Movie.Genre.HasFlag(genre))
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintShows(Day day)
        {
            foreach (Show s in shows)
            {
                if (s.Day == day)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintShows(Time time)
        {
            foreach (Show s in shows)
            {
                if (s.Time == time)
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintShows(string actor)
        {
            foreach (Show s in shows)
            {
                if (s.Movie.Cast.Contains(actor))
                {
                    Console.WriteLine(s);
                }
            }
        }

        public void PrintShows(Day day, Time time)
        {
            foreach (Show s in shows)
            {
                if (s.Day == day && s.Time == time)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}
