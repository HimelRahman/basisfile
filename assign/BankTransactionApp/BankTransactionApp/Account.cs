using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransactionApp
{
    class Account
    {
        private string number;
        private string name;
        private double balance;

        public string Name
        {
            set
            {
                if (value.Length >= 3)
                    name = value;
            }

            get
            {
                return name;
            }
        }

        public string Number
        {
            set
            {
                
                    number = value;
            }

            get
            {
                return number;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
        }

        public void Deposit(Double amount)
        {
            balance+= amount;
        }
        public void Withdraw(Double amount)
        {
            balance-= amount;
        }
        
    }
}
