using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    delegate void Formatter(double cost);
    class Program
    {
        static void Main(string[] args)
        {
            //instantiating the delegates
            Formatter can = new Formatter(Canada);
            Formatter Ind = India;
            Formatter fra = new Program().France;
            Formatter all = can + Ind + fra;

            //Invoking the methods using the delegates
            DisplayPrice(can, 10.50);
            DisplayPrice(Ind,345.664);
            DisplayPrice(fra,25.10);
            Console.WriteLine("Displaying all delegates at once");
            DisplayPrice(all,123.45);
        }
        static void DisplayPrice(Formatter formatter, double price)
        {
            formatter(price);

        }

        #region All the method defination
        #endregion


        static void Canada(double cost)
        {
            Console.WriteLine($"$ {cost:F2}");
        }

        static void India(double cost)
        {
            Console.WriteLine($"Rs {cost:F2}");
        }

         void France(double cost)
        {
            Console.WriteLine($"{cost:F2} Euro");
        }

    }
}
