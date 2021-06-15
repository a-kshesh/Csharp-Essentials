using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMethodQuerySystax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = Person.GetPersons();

            //1.	Show all non-US citizens
            var q1 = persons.Where(p => p.Country != "US");
            Console.WriteLine("1. Show all non-US citizens\n\n");
            foreach(var p in q1)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();
            
            //2.	Shows only the name of all US citizens
            var q2 = persons.Where(p => p.Country == "US").Select(p => p.Name);
            Console.WriteLine("\n\n2. Shows only the name of all US citizens\n\n");
            foreach(var p in q2)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();

            //3.	Show all females from India
            var q3 = persons.Where(p => p.IsFemale && p.Country == "India");
            Console.WriteLine("\n\n3. Show all females from India\n\n");
            foreach(var p in q3)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();

            //4. Sort the collection by last name and then first name
            var q4 = persons.OrderBy(p => p.Name.Split()[1]).ThenBy(p=>p.Name.Split()[0]);
            Console.WriteLine("\n\n4. Sort the collection by last name and then first name\n\n");
            foreach(var p in q4)
            {
                Console.WriteLine(p);
            }

            Console.ReadLine();

            //5.	Group the collection by gender
            var q5 = persons.GroupBy(p => p.IsFemale);
            Console.WriteLine("\n\n5. Group the collection by gender\n\n");
            foreach(var p in q5)
            {
                foreach(var pp in p)
                {
                    Console.WriteLine(pp);
                }
                
            }

            Console.ReadLine();

            //6.	The first longest word in the string array words (See the Aggregate example above)
            string[] words = "the quick brown fox jumps over the lazy dog".Split();
            var q6= words.Aggregate((longest, word) => word.Length > longest.Length ? word : longest);
            Console.WriteLine("\n\n6. The first longest word in the string array words\nthe quick brown fox jumps over the lazy dog\n\n");
            Console.WriteLine(q6);

            Console.ReadLine();

            //7.The first word with the most vowels.
            //var q7 = words.Aggregate((first,word)=> word.);


            Console.ReadLine();

            //8.	All the elements in second and third with no duplicates.
            string[] first = "a b b c d c".Split();
            string[] second = "a b c e".Split();
            string[] third = "a c d e".Split();
          
            Console.WriteLine($"\n\nFirst: {string.Join(" ", first)}");
            Console.WriteLine($"Second: {string.Join(" ",second)}");
            Console.WriteLine($"Third: {string.Join(" ", third)}");
            Console.WriteLine("\n\n8. All the elements in second and third with no duplicates.\n");
            var q8 = second.Union(third);
            Console.WriteLine(string.Join(" ",q8));

            //9.	Inner, left and right join on persons and fruits.
            List<Fruit> fruits = Fruit.GetFruits();

            Console.WriteLine("\n\n9.Inner, left and right join on persons and fruits.\n\n");
            Console.WriteLine("Inner Join");
            var q10 = from p in persons join f in fruits on 


        }
    }
}
