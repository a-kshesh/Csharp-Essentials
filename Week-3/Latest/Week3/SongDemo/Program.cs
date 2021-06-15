using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SongDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.LoadSongs("song.txt");
            Library.DisplaySongs();
        }
    }

    enum SongGenre
    {
        UnUnclassified = 0,
        Pop = 1,
        Rock = 2,
        Blues = 4,
        Country = 8,
        Metal = 16,
        Soul = 32
    }

    class Song
    {
        public string Artist { get; }
        public string Title { get; }
        public double Length { get; }
        public SongGenre Genre { get; }

        public Song(string Title, string Artist, double Length, SongGenre Genre)
        {
            this.Title = Title;
            this.Length = Length;
            this.Artist = Artist;
            this.Genre = Genre;
        }

        public override string ToString()
        {
            return $"The Song is {Title} by {Artist} {Length} min in length {Genre} in Genre";
        }

    }

    static class Library
    {
        private static List<Song> songs = new List<Song> {};

        public static void LoadSongs(string fileName)
        {
            TextReader reader = new StreamReader(fileName);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                songs.Add(new Song(line, reader.ReadLine(), Convert.ToDouble(reader.ReadLine()), SongGenre.UnUnclassified));
                
            }
            reader.Close();

        }

        public static void DisplaySongs()
        {
            foreach (Song s in songs)
            {
                Console.WriteLine(s);
            }
        }

        public static void DisplaySongs(double longerThan)
        {
            foreach (Song s in songs)
            {
                if(s.Length > longerThan)
                {
                    Console.WriteLine(s);
                }
                
            }
        }

        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song s in songs)
            {
                if (s.Genre == genre)
                {
                    Console.WriteLine(s);
                }

            }
        }

        public static void DisplaySongs(string artist)
        {
            foreach (Song s in songs)
            {
                if (s.Artist == artist)
                {
                    Console.WriteLine(s);
                }

            }
        }


    }
}