using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Practice
{
    class Transaction
    {
        public string AccountNumber { get; }
        public double Amount { get; }
        public Person Originator { get; }
        public DateTime Time { get; }

        public Transaction(string accountNumber, double Amount, Person person, DateTime time)
        {
            this.AccountNumber = accountNumber;
            this.Amount = Amount;
            this.Originator = person;
            this.Time = time;
        }
    }
}
