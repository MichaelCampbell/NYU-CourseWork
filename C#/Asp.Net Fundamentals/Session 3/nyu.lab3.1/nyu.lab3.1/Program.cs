using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nyu.lab3._1
{
    class Program
    {

        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount(Guid.NewGuid());
            b1.CreateAccount();
            b1.getBalance();
            b1.PrintAccount();

            BankAccount b2 = new SavingsAccount(Guid.NewGuid(), true);

            List<BankAccount> banks = new List<BankAccount>();
            banks.Add(b1);
            //banks.Add(b2);
            //banks.Add(b3);
            

            foreach (BankAccount b in banks)
            {
                
            }
            

            
        }
    }
}
