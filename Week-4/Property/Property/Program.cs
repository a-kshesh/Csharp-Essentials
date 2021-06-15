using System;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { FName = "AKSHESH", LName = "CHAUDHARI" };
            Console.WriteLine("Hello World!");
            Console.WriteLine(p.Name);
        }
    }
    class Person
    {
        public String FName { get; set; }
        public String LName { get; set; }

        public string Name
        {
            get
            {
                return $"{FName} {LName}";
            }
        }
    }
}
