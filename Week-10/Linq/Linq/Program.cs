using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            List<Person> persons = person.getPerson();

            Console.WriteLine("\n\nNot US Citizens\n\n");
            var V1 = persons.Select(p =>p.Country!="US");
            foreach (var v in V1)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n\nOnly US Citizens\n\n");
            var V2 = persons.Where(p => p.Country.Equals("US")).Select(n => n.Name);
            foreach (var v in V2)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\nAll Females from India\n\n");
            var V3 = persons.Where(p => p.Country.Equals("India") && p.IsFemale).Select(n => n);
            foreach (var v in V3)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\nSorted by first name\n\n");
            var V4 = persons.OrderBy(p => p.Name.Split()[0]).Select(n => n.Name);
            foreach (var v in V4)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\nSorted by last name\n\n");
            var V5 = persons.OrderBy(p => p.Name.Split()[1]).Select(n => n.Name);
            foreach (var v in V5)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\nGroup by Gender=female\n\n");
            var V6 = persons.Where(p => p.IsFemale);
            foreach (var v in V6)
            {
                    Console.WriteLine(v);
            }

            Console.WriteLine("\n\nGroup by Gender=male\n\n");
            var V7 = persons.Where(p => p.IsFemale==false);
            foreach (var v in V7)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("\n\nfirst longest word in the string array words \n\n");
            string[] words = "the quick brown fox jumps over the lazy dog".Split();
            var V8= words.Aggregate((longest, word) => word.Length > longest.Length ? word : longest);  
            Console.WriteLine(V8);

            Console.WriteLine("\n\nFirst word with most vowels\n\n");
            var V7 = persons.Where(p => p.IsFemale == false);
            foreach (var v in V7)
            {
                Console.WriteLine(v);
            }

        }


    }
}
