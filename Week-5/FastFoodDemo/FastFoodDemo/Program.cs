using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server("John");
            Superviser s1 = new Superviser("Amily");
            Manager m = new Manager("Alex");
            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(m);
           
        }
    }

    class Server
    {
        protected List<String> duties = new List<string> { };
        protected double wages;
        String Name { get; }

        public Server(String name)
        {
            this.Name = name;
            wages = 14.15;
            duties.Add("take order");
            duties.Add("confirm order");
            duties.Add("serve order");
            duties.Add("get feedback");


        }

        public override string ToString()
        {
            return $"{Name} {wages} {String.Join(", ", duties)}";
        }
    }

    class Superviser : Server
    {
        public Superviser(String name)
            : base(name)
        {
            duties.Add("check Serving");
            wages = 17.15;
        }
    }

    class Manager : Superviser
    {
        public Manager(String name)
            :base(name)
        {
            duties.Add("Billing");
            wages = 20.00;
        }
    }
  
}
