using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display<int>(123);
            //Display<string>("Akshesh");
            //Display<double>('A');
            //Display<Student>(new Student() { Name="Akshesh",Gpa=3.9});
            //int a= 1,b=2;
            //Swap(ref a, ref b);

            //


            Generic1<string> g = new Generic1<string>("Akshesh");
            Console.WriteLine(g.Data);

            Generic1<Student> s = new Generic1<Student>(new Student() { Name = "Akshesh", Gpa = 4.0 });
            Console.WriteLine(s.Data);

            Generic2<int> i = new Generic2<int>();
            i.Show(1);

            Generic2<Student> ss = new Generic2<Student>();
            ss.Show(new Student() { Name = "Akshesh", Gpa = 4.1 });
        }

        static void Display<T>(T value)
        {
            Console.WriteLine(value);
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }



    }


    interface IShowable<T>
    {
        void Show(T value);
    }

    class Generic2<T> : IShowable<T>
    {
        public void Show(T value)
        {
            Console.WriteLine(value);
        }
    }

    class Generic1<T>
    {
        public T Data { get; }
        public Generic1(T data)
        {
            Data = data;
        }

    }

    class Student
    {
        public string Name { get; set; }
        public double Gpa { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, GPA: {Gpa}";
        }

    }
}
