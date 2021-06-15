using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompuledProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { FName = "Narendra", LName = "Pershad" };
            Console.WriteLine(p.FName);
            Console.WriteLine(p.LName);
            Console.WriteLine(p.Name);
        }
    }
    class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Name
        {
            get
            {
                return $"{FName} {LName}";
            }
        }

    }
}
