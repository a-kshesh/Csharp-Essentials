using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTracker
{
    public class Student
    {
        public string FName { get; }
        public string LName { get; }
        public string ProgramCode { get; }
        public bool IsDomestic { get; }
        public double Gpa { get; private set; }
        public int Semester { get; private set; }

        public Student(string fname, string lname,
            string programCode, int semester = 1,
            double gpa = 0, bool isDomestic = true)
        {
            FName = fname;LName = lname;ProgramCode = programCode;
            Semester = semester;Gpa = gpa;IsDomestic = isDomestic;
        }

        public static List<Student> GetStudents()
            => new List<Student>()
            {
                new Student("Dewarkar","Agarwal", "3428", 3, 0, false),
                new Student("Ozgun","Ceci", "3409", 4, 3.4 ),
                new Student("Harsimran","Kaur", "3428", 3, 0, false),
                new Student("Steve","Sultan", "3529"),
                new Student("Meera","Mohan", "3818", 3, isDomestic:false )
            };
    }
}
