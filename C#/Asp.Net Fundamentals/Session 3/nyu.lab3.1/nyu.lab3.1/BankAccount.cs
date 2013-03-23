using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nyu.lab3._1
{
    public class BankAccount
    {
        private decimal _balance;
        //private decimal Balance { get; set; }
        public decimal getBalance()
        {
            return _balance;
        }
        private void setBalance(decimal newBalance)
        {
            _balance = newBalance;
        }
        public Guid AccountNum { get; set; }
        public string AccountOwner { get; set; }

        public void MakeDeposit(decimal deposit)
        {
            if (deposit <= 0)
            {
                Console.WriteLine("Invalid Deposit");
            }
            else
                _balance += deposit;
        }
        public void MakeWithdrawal(decimal withdrawal)
        {
            if (withdrawal > _balance)
            {
                Environment.Exit(0);
            }

            //Console.WriteLine("You cannot pull that much");
            _balance -= withdrawal;
        }
        public BankAccount(Guid AcctNum)
        {
            setBalance(0.00M);
            AccountNum = AcctNum;
        }
        public BankAccount(Guid AcctNum, decimal initBalance)
        {
            setBalance(initBalance);
        }

        public BankAccount CreateAccount()
        {
            //AccountNum = Guid.NewGuid();
            Console.Write("Hello, Please enter your name: ");
            string name = Convert.ToString(Console.ReadLine());
            AccountOwner = name;
            Console.Write("Hello, Please enter your Initial Deposit Amount: $");
            decimal newBalance = Convert.ToDecimal(Console.ReadLine());
            setBalance(newBalance);

            return this;
        }
        public void PrintAccount()
        {
            Console.WriteLine("\nAccount Owner: " +  AccountOwner.ToUpper() + "\nCurrent Balance: $" + getBalance() + "\nAccount Number: " + AccountNum);
        }
    }
}
