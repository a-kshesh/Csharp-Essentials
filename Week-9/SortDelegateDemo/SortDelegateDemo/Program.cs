using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var students =Student.GetStudents();
            foreach (Student student in students)
            {
                Console.WriteLine( student);
            }
            //sorting by first name
            students.Sort(CompareStudent);

            students.Sort((Student a, Student b) => a.Lname.CompareTo(b.Lname));
        }
        static int CompareStudent(Student a, Student b)
        {
            return a.Fname.CompareTo(b.Fname);
        }
    }

    class Student
    {
        static Random random = new Random();
        static int NEXT_ID = 100;
        public String Id { get; }
        public String Fname { get; }
        public String Lname { get; }
        public int Age { get; }
        public double Gpa { get; }

        public Student(string fName, string lName)
        {
            Fname = fName;
            Lname = lName;
            Id = "" + NEXT_ID++;
            Age = random.Next(18,30);
            Gpa = random.Next(200, 400) / 100;
        }
        public override string ToString()
        {
            return $"{Id} {Lname} age {Age} gpa {Gpa}";
        }

        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student("akshesh","Chaudhari"),
                new Student("yash","amrutiya"),
                new Student("ashish","patadiya"),
                new Student("shruti","thakur"),
                new Student("priyank","shah")

            };
                
             
        }
    }
}
