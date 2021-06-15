using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = Person.GetPersons();

            var r1 = from p in persons
                     select p;

            r1 = from p in persons where p.IsFemale select p;

            r1 = from p in persons where p.Country == "US" select p;

            r1 = from p in persons where p.Name.Split()[0] == "W" select p;

            r1 = from p in persons orderby p.Age select p;

            r1 = from p in persons orderby p.Name.Split()[1] select p;

            r1 = from p in persons orderby p.Name.Split()[1], p.Name.Split()[0] select p;

            var r2 = from p in persons
                     group p by p.Age;

            var r3 = from p in persons where p.Country == "US" select p.Name;

            int[] numbers = { 2, 3, 4, 5 };
            //the following returns a query of type IEnumerable<a>
            var r4 =
            from x in numbers
            select new { Radius = x, Area = Math.PI * x * x };



            //foreach (var p in r1)
            //{
            //    Console.WriteLine(p);
            //}

            //foreach (var aGroup in r2)
            //{
            //    Console.WriteLine("{0} ({1})",
            //      aGroup.Key, aGroup.Count());
            //    foreach (var item in aGroup)
            //        Console.WriteLine("    " + item);
            //}

            //1.	Show the persons with assets of over 50B dollars.
            var r5 = from p in persons where p.Asset > 50 select p;

            Console.WriteLine("\n\n\nShow the persons with assets of over 50B dollars.\n\n");
            foreach(var p in r5)
            {
                Console.WriteLine(p);
            }

            //2.	Show all non-US citizens.
            var r6 = from p in persons where p.Country != "US" select p;

            Console.WriteLine("\n\n\nShow all non-US citizens.\n\n");
            foreach (var p in r6)
            {
                Console.WriteLine(p);
            }

            //3.	Show all females from India.
            var r7 = from p in persons where p.IsFemale && p.Country == "India" select p.Name;

            Console.WriteLine("\n\n\nShow all females from India.\n\n");
            foreach (var p in r7)
            {
                Console.WriteLine(p);
            }

            //4.	Show all persons whose first name is less than five letters long.
            var r8 = from p in persons where p.Name.Split()[0].Length < 5 select p;
            Console.WriteLine("\n\n\nShow all persons whose first name is less than five letters long\n\n");
            foreach (var p in r8)
            {
                Console.WriteLine(p);
            }

            //5.	Sort the collection by assets
            var r9 = from p in persons orderby p.Asset select $"{p.Name} {p.Asset}";
            Console.WriteLine("\n\n\nSort the collection by assets\n\n");
            foreach (var p in r9)
            {
                Console.WriteLine(p);
            }

            //6.	Group the collection by country.
            var r10 = from p in persons group p by p.Country;
            Console.WriteLine("\n\n\nGroup the collection by country.\n\n");
            foreach (var group in r10)
            {
                Console.WriteLine($"\n{group.Key}");
                foreach(var p in group)
                {
                    Console.WriteLine(p);
                }
            }

            //7.	Sort the above grouping.
            var r11 = from p in persons orderby p.Country group p by p.Country;
            Console.WriteLine("\n\n\nSort the above grouping.\n\n");
            foreach (var group in r11)
            {
                Console.WriteLine($"\n{group.Key}");
                foreach (var p in group)
                {
                    Console.WriteLine(p);
                }
            }

            //8. Females age less then 60, having assests greater than 35B order by age;
            var r12 = from p in persons orderby p.Age where p.IsFemale && p.Age < 60 && p.Asset < 35 select p;
            Console.WriteLine("\n\n\nFemales age less then 60, having assests greater than 35B order by age;\n");
            foreach (var p in r12)
            {
                Console.WriteLine(p);
            }

            //9.country having maximum number of female

            var r13 = from p in persons where p.IsFemale group p by p.Country into countryGrp orderby countryGrp.Count() descending select countryGrp;

            Console.WriteLine("\n\n\ncountry having maximum number of female\n");
            foreach (var group in r13.Take(1))
            {
                Console.WriteLine($"\n{group.Key}");
                foreach (var p in group)
                {
                    Console.WriteLine(p);
                }
            }

        }
    }
}
