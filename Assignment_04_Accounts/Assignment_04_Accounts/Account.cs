using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    abstract class Account
    {
        public List<Person> users = new List<Person>();

        public List<Transaction> transactions = new List<Transaction>();

        private static int LAST_NUMBER = 100000;

        public string Number { get; protected set; }
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }

        public Account(string type, double balance)
        {
            Number = type + LAST_NUMBER.ToString();
            LAST_NUMBER++;
            Balance = balance;
            LowestBalance = balance;
        }

        public void Deposit(double amount, Person person)
        {
            if (Balance > (Balance + amount))
            {
                LowestBalance = Balance + amount;
            }
            else
            {
                LowestBalance = Balance;
            }
            Balance = Balance + amount;
            transactions.Add(new Transaction(Number, amount, person, DateTime.Now));
        }

        public void AddUser(Person person)
        {
            users.Add(person);
        }

        public bool IsUser(string name)
        {
            foreach (Person p in users)
            {
                if (p.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public abstract void PrepareMonthlyReport();

        public override string ToString()
        {
            return $"Account Number: {Number}\nBalance: {Balance:F2}\nUsers: {string.Join(",", users)}\nTransactions:\n\t{string.Join("\n\n\t", transactions)}\n\n";
        }
    }
}
