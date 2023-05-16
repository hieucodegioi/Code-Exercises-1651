using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    internal class BankAccount
    {
        public int Id;
        public decimal Balance;

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }
    }
}
