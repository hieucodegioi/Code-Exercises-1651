using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    internal class Class
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> account = new Dictionary<int, BankAccount>();
            string command = " ";
            do {
                command = Console.ReadLine();
                var cmdArgs = command.Split();
                var cmdType = cmdArgs[0];
                switch (cmdType)
                {
                    case "Create":
                        Create(cmdArgs, account);
                        break;
                    case "Deposit":
                        Deposit(cmdArgs, account);
                        break;
                    case "Withdraw":
                        Withdraw(cmdArgs, account);
                        break;
                    case "Print":
                        Print(cmdArgs, account);
                        break;
                }
            } while (String.Equals(command, "End") == false);
        


        }
        private static void Create(string[] cmdArgs, Dictionary<int, BankAccount> account)
        {
            var id = int.Parse(cmdArgs[1]);

            if (account.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount { Id = id };
                account.Add(id, acc);
            }
        }
        private static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(cmdArgs[1]);
            var amount = decimal.Parse(cmdArgs[2]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(amount);
            }
        }


        private static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> account)
        {
            var id = int.Parse(cmdArgs[1]);
            var amount = decimal.Parse(cmdArgs[2]);

            if (!account.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else if (account[id].Balance < amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                account[id].Withdraw(amount);
            }
        }

        private static void Print(string[] cmdArgs, Dictionary<int, BankAccount> account)
        {
            var id = int.Parse(cmdArgs[1]);

            if (!account.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(account[id].ToString());
            }
        }
    }
}
