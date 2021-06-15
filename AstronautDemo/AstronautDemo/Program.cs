using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronautDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Astronaut> astronauts = new List<Astronaut>();
            Astronaut a = Astronaut.CreateAstronaut("Yuri Gagarin", "Russian");  // 1
            if (a != null) astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Alan Shepard", "American");           // 2
            if (a != null) astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Virgil Grissom", "American");         // 3
            if (a != null) astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Gherman Titov", "Russian");           // 4
            if (a != null) astronauts.Add(a);

            a = Astronaut.CreateAstronaut("John Glenn", "American");             // 5
            if (a != null) astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Scott Carpenter", "American");        // 6
            if (a != null) astronauts.Add(a);

            Console.WriteLine("Only 5 astronauts created");
            int count = 1;
            foreach (Astronaut astronaut in astronauts)
            {
                Console.WriteLine($"{count++} {astronaut}");
            }
           
        }

    }

    class Astronaut
    {
        static int ASTRONAUT_COUNT = 0 ;
        static int THRESHOLD = 5;
        string Name { get; }
        string Nationality { get; }

        private Astronaut(string name, string nationality)
        {
            this.Name = name;
            this.Nationality = nationality;
        }
        public static Astronaut CreateAstronaut(string name, string nationality)
        {

            if (ASTRONAUT_COUNT < THRESHOLD)
            {
                Astronaut ast1 = new Astronaut(name, nationality);
                ASTRONAUT_COUNT++;
                return ast1;
            }
            else
            {
                return null;

            }


        }
        public override string ToString()
        {
            return ($"The astronaut {Name}, {Nationality}");
        }
    }
}
