using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Practice
{
    class Person
    {
        private string password;
        public bool IsAuthenticated { get; private set; }
        public string SIN { get;}
        public string Name { get; }

        public Person(string name, string sin)
        {
            Name = name;
            SIN = sin;
            password = sin.Substring(0,3);
        }

        public void Login(string password)
        {
            if (password != this.password)
            {
                IsAuthenticated = false;
            }
            else
            {
                IsAuthenticated = true;
            }
        }

        public void Logout()
        {
            IsAuthenticated = false;
        }

        public override string ToString()
        {
            return $"UserName: {password} ,SIN NO: {SIN} and {IsAuthenticated}";
        }

    }
}
