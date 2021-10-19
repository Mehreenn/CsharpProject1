using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    abstract class Account
    {
        public double Balance { get; set; }
        public string ClientName { get; set; }
        public int Number { get; set; }

        //constructor
        public Account(int number,
            string clientName,
            double balance)
        {
            Balance = balance;
            ClientName = clientName;
            Number = number;
        }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);
            
    }
    
}
