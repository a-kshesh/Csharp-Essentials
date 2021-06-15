using System;
using System.Collections.Generic;
using System.IO;
namespace Medal
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", "Gold", 2012, true);
            //create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", "Gold", 2012, false);
            List<Medal> medals = new List<Medal>(){ m1, m2};
            medals.Add(new Medal("Ryan Cochrane", "Swimming", "Silver", 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", "Silver", 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", "Gold", 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", "Bronze", 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", "Gold", 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", "Gold", 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", "Bronze", 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", "Bronze", 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", "Gold", 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", "Gold", 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", "Bronze", 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", "Bronze", 2012, false));
            
            //prints a numbered list of 16 medals. 
            Console.WriteLine("\n\nAll 16 medals");
            foreach (Medal m in medals)
            {  
                Console.WriteLine($"{count}: {m}");
                count++;
            }

            //prints a numbered list of 9 gold medals
            count = 1;
            Console.WriteLine("\n\nAll 9 gold medals");
            foreach (Medal m in medals)
            {
                if (m.color.Equals("Gold")) {
                    Console.WriteLine($"{count}: {m}");
                    count++;
                }
            }
            count = 1;
          
            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals");
            foreach (Medal m in medals)
            {
                if (m.year==2012)
                {
                    Console.WriteLine($"{count}: {m}");
                    count++;
                }
                
            }
            count = 1;
            
            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals");
            foreach (Medal m in medals)
            {
                if (m.year == 2012 && m.color.Equals("Gold"))
                {
                    Console.WriteLine($"{count}: {m}");
                    count++;
                }
            }
            count = 1;

            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            foreach (Medal m in medals)
            {
                if (m.isRecord)
                {
                    Console.WriteLine($"{count}: {m}");
                    count++;
                }
                
            }
            count = 1;
            //saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");
            TextWriter medalwriter = new StreamWriter("Medals.txt");
            for (int i=0; i< medals.Count;i++)
            {
                medalwriter.WriteLine(medals[i].ToString());
            }
        }
    }
    class Medal
    {
        public String name { get; }
        public string theEvent { get; } 
        public String color { get; }
        public int year { get; }
        public bool isRecord { get; }

        public Medal(string name, string theEvent, string color, int year, bool isRecord)
        {
            this.name = name;
            this.theEvent = theEvent;
            this.color = color;
            this.year = year;
            this.isRecord = isRecord;
        }

        public override string ToString()
        {
            return $"{year} - {theEvent} {(isRecord==true?"(R)":"")} {name}({color})";
        }
    }
}
