using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Theatre
{
    class Movie
    {
        public int Length { get; }
        public int Year { get; }
        public string Title { get; }
        public Genre Genre { get; private set; }
        public List<string> Cast;

        public Movie(string title, int year, int length)
        {
            this.Title = title;
            this.Length = length;
            this.Year = year;
            this.Cast = new List<string> { };
        }

        public void AddActor(string actor)
        {
            this.Cast.Add(actor);
        }

        public void SetGenre(Genre genre)
        {
            this.Genre = genre;
        }

        public override string ToString()
        {
            return $"{Title} -- {Year} -- {Length}mins -- {Genre} -- {string.Join(",",Cast)}";
        }

    }
}
