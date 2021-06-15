using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    class Person
    {
        private string password;
        public bool IsAuthenticated { get; private set; }
        public string SIN { get; }
        public string Name { get; }

        public Person(string name, string sin)
        {
            this.Name = name;
            this.SIN = sin;
            this.password = sin.Substring(0, 3);
        }

        public void Login(string password)
        {
            if (this.password != password)
            {
                IsAuthenticated = false;
                throw new AccountException(ExceptionEnum.PASSWORD_INCORRECT);
            }
            else
            {
                IsAuthenticated = true;
            }
        }

        public void LogOut()
        {
            IsAuthenticated = false;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
