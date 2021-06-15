using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    static class Bank
    {
        public static List<Account> ACCOUNTS;
        private static List<Person> USERS;

        static Bank()
        {
            USERS = new List<Person>(){
                        new Person("Narendra", "1234-5678"),
                        new Person("Ilia", "2345-6789"),
                        new Person("Tom", "3456-7890"),
                        new Person("Syed", "4567-8901"),
                        new Person("Arben", "5678-9012"),
                        new Person("Patrick", "6789-0123"),
                        new Person("Yin", "7890-1234"),
                        new Person("Hao", "8901-2345"),
                        new Person("Jake", "9012-3456"),
                        new Person("Joanne", "1224-5678"),
                        new Person("Nicoletta", "2344-6789")
            };
            ACCOUNTS = new List<Account>{
                        new VisaAccount(),              //VS-100000
                        new VisaAccount(150, 500),     //VS-100001      //-500
                        new SavingAccount(5000),        //SV-100002
                        new SavingAccount(),            //SV-100003
                        new CheckingAccount(2000),      //CK-100004
                        new CheckingAccount(1500, true),//CK-100005
                        new VisaAccount(50, 550),      //VS-100006      //-550    
                        new SavingAccount(1000),        //SV-100007
            };
            //associate users with accounts
            ACCOUNTS[0].AddUser(USERS[0]);
            ACCOUNTS[0].AddUser(USERS[1]);
            ACCOUNTS[0].AddUser(USERS[2]);

            ACCOUNTS[1].AddUser(USERS[3]);
            ACCOUNTS[1].AddUser(USERS[4]);
            ACCOUNTS[1].AddUser(USERS[5]);

            ACCOUNTS[2].AddUser(USERS[6]);
            ACCOUNTS[2].AddUser(USERS[7]);
            ACCOUNTS[2].AddUser(USERS[8]);

            ACCOUNTS[3].AddUser(USERS[9]);
            ACCOUNTS[3].AddUser(USERS[10]);

            ACCOUNTS[4].AddUser(USERS[2]);
            ACCOUNTS[4].AddUser(USERS[4]);
            ACCOUNTS[4].AddUser(USERS[6]);

            ACCOUNTS[5].AddUser(USERS[8]);
            ACCOUNTS[5].AddUser(USERS[10]);

            ACCOUNTS[6].AddUser(USERS[1]);
            ACCOUNTS[6].AddUser(USERS[3]);

            ACCOUNTS[7].AddUser(USERS[5]);
            ACCOUNTS[7].AddUser(USERS[7]);

        }

        public static void PrintAccounts()
        {
            foreach (Account a in ACCOUNTS)
            {
                Console.WriteLine(a);
            }
        }

        public static void PrintPersons()
        {
            foreach (Person p in USERS)
            {
                Console.WriteLine(p);
            }
        }
        public static Person GetPerson(string name)
        {
            foreach (Person p in USERS)
            {
                if (p.Name == name)
                {
                    return p;
                }
            }
            throw new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
        }

        public static Account GetAccount(string number)
        {
            foreach (Account a in ACCOUNTS)
            {
                if (a.Number == number)
                {
                    return a;
                }
            }
            throw new AccountException(ExceptionEnum.ACCOUNT_DOES_NOT_EXIST);
        }
    }
}
