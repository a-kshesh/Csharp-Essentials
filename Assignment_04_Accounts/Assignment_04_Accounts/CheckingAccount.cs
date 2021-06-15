using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    class CheckingAccount : Account, ITransaction
    {

        private static double COST_PER_TRANSACTION = 0.05;
        private static double INTEREST_RATE = 0.005;
        private bool hasOverdraft;

        public CheckingAccount(double balance = 0, bool hasOverdraft = false)
            : base("CK-", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }



        public override void PrepareMonthlyReport()
        {
            double service_charge = transactions.Count * COST_PER_TRANSACTION;
            double intrest = (this.Balance * INTEREST_RATE) / 12;
            this.Balance = (this.Balance + intrest) - service_charge;
            this.transactions.Clear();
        }

        public void Withdraw(double amount, Person person)
        {
            if (amount > this.Balance && !hasOverdraft)
            {
                throw new AccountException(ExceptionEnum.NO_OVERDRAFT);
            }
            else if (!this.users.Contains(person))
            {
                throw new AccountException(ExceptionEnum.USER_DOES_NOT_EXIST);
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

        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }
    }
}
