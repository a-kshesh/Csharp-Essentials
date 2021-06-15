using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
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

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\n\tAmount: {Amount}\n\tOriginator: {Originator}\n\tTime: {Time.ToShortTimeString()}";
        }
    }
}
