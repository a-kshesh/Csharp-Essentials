using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    class VisaAccount : Account, ITransaction
    {
        private double creditLimit;
        private static double INTEREST_RATE = 0.1995;

        public VisaAccount(double balance = 0, double creditLimit = 1200)
            : base("VS-", balance)
        {
            this.creditLimit = creditLimit;
        }

        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }

        public void DoPurchase(double amount, Person person)
        {
            if (amount > this.creditLimit)
            {
                throw new AccountException(ExceptionEnum.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            }
            else if (!this.users.Contains(person))
            {
                throw new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            else if (!person.IsAuthenticated)
            {
                throw new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN);
            }
            else
            {
                base.Deposit(-amount, person);
            }
        }

        public override void PrepareMonthlyReport()
        {
            double intrest = (this.LowestBalance * INTEREST_RATE) / 12;
            this.Balance = this.Balance - intrest;
            this.transactions.Clear();
        }

        public void Withdraw(double amount, Person person)
        {

        }
    }
}
