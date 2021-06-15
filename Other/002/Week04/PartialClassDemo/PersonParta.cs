using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    partial class Person
    {
        public Person(string fname, string lname)
        {
            FName = fname;
            Lname = lname;
        }
    }
}
