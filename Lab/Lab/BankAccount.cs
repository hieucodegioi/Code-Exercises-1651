using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class BankAccount
    {
        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient balance");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return $"Account ID{Id}, balance {Balance:F2}";
        }
    }
}
