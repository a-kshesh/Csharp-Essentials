using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SongDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Library.LoadSongs("song.txt");
            Library.LoadSongs("song1.txt");
            Console.WriteLine("\n All Songs\n");
            Library.DisplaySongs();

            Console.WriteLine("\n Songs' SongLength > 3.4\n");

            Library.DisplaySongs(3.4);

            Console.WriteLine("\n artist : Justin Bebier\n");

            Library.DisplaySongs("Justin Bebier");

            Console.WriteLine("\n\n genre : pop \n");

            Library.DisplaySongs(SongGenre.Pop);


        }
    }
  
    enum SongGenre
    {
        Unclassified = 0,
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
            this.Artist = Artist;
            this.Length = Length;
            this.Genre = Genre;
        }


        public override string ToString()
        {
            return ($" {Artist}  {Title}  {Length}  {Genre}");
        }
    }

    static class Library
    {
        public static int index = 1;
        private static List<Song> songs = new List<Song> { };

        public static void LoadSongs(string fileName)
        {
            TextReader reader = new StreamReader(fileName);
            String l;
            while ((l = reader.ReadLine()) != null)
            {
                songs.Add(new Song(l, reader.ReadLine(), Convert.ToDouble(reader.ReadLine()), (SongGenre)Enum.Parse(typeof(SongGenre), reader.ReadLine())));
            }
        }

        public static void DisplaySongs()
        {
            
            foreach (Song s in songs)
            {
                Console.WriteLine(index+" "+s);
                index++;
            }
            index = 1;
        }

        public static void DisplaySongs(double longerThan)
        {
            foreach (Song s in songs)
            {
                if (s.Length > longerThan)
                {
                    Console.WriteLine(index + " " + s);
                    index++;
                }

            }
            index = 1;
        }

        public static void DisplaySongs(SongGenre genre)
        {
            foreach (Song s in songs)
            {
                if (s.Genre == genre)
                {
                    Console.WriteLine(index + " " + s);
                    index++;
                }

            }
            index = 1;
        }

        public static void DisplaySongs(string artist)
        {
            foreach (Song s in songs)
            {
                if (s.Artist.Equals(artist))
                {
                    Console.WriteLine(index + " " + s);
                    index++;
                }
            }
            index = 1;
        }
    }
}

