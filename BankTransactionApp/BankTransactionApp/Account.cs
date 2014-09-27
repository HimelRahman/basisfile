using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransactionApp
{
    class Account
    {
        public string Number;
        public string Name;
        public Double balance;

        public void Deposit(Double amount)
        {
            balance+= amount;
        }
        public void Withdraw(Double amount)
        {
            balance-= amount;
        }
        public string Report()
        {
            return (Name + ", " + "your acccount number: " + Number + " and it's balance: " + balance + "taka"); 
        }
    }
}
