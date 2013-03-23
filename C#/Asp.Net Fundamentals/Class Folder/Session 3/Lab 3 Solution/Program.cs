using System;
using System.Collections.Generic;

namespace NYU.Lab2
{
    class Program
    {
        static List<BankAccount> accountsList = new List<BankAccount>();

        static void Main()
        {
            string command = "";
            do
            {
                Console.Clear();
                PrintWelcomeScreen();
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "q":
                        break;
                    case "l":
                        ListAccounts();
                        break;
                    case "c":
                        CreateAccount();
                        break;
                    case "d":
                        MakeDeposit();
                        break;
                    case "w":
                        try
                        {
                            MakeWithdrawl();
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid withdrawl");
                            Console.ResetColor();
                        }
                        break;
                    case "b":
                        ListBalance();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Command!  Press any key to continue.");
                        Console.ResetColor();
                        break;
                }
            } while (command != "q");

            Console.Write("\n\n(Done.  Press any key to continue)");
            Console.ReadKey();
        }

        private static void ListBalance()
        {
            BankAccount account = PromptForAccount();
            ListBalance(account);
        }
        private static void ListBalance(BankAccount account)
        {
            if (account != null)
            {
                Console.WriteLine("Account\tBalance");
                Console.WriteLine("===============================");
                Console.WriteLine(account.ToString());
            }
            else
            {
                PrintInvalidAccountMessage();
            }

            Console.Write("\n\n(press any key to continue)");
            Console.ReadKey();
        }

        private static void MakeWithdrawl()
        {
            BankAccount account = PromptForAccount();
            if (account == null)
            {
                PrintInvalidAccountMessage();
                return;
            }
            Console.Write("Amount to withdraw: ");
            decimal amt;
            decimal.TryParse(Console.ReadLine(), out amt);

            account.MakeWithdrawl(amt);
            ListBalance(account);
        }

        private static void MakeDeposit()
        {
            BankAccount account = PromptForAccount();
            if (account == null)
            {
                PrintInvalidAccountMessage();
                Console.Write("\n\n(press any key to continue)");
                Console.ReadKey();
                return;
            }
            Console.Write("Amount to deposit: ");
            decimal amt;
            decimal.TryParse(Console.ReadLine(), out amt);

            account.MakeDeposit(amt);
            ListBalance(account);
        }

        private static void PrintInvalidAccountMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid account number");
            Console.ResetColor();
        }

        private static void CreateAccount()
        {
            uint num;
            Console.Write("Enter Account Number: ");
            uint.TryParse(Console.ReadLine(), out num);
            if (num == 0)
            {
                PrintInvalidAccountMessage();
                return;
            }
            BankAccount account = new BankAccount(num);

            Console.Write("Enter initial balance: ");
            decimal bal;
            decimal.TryParse(Console.ReadLine(), out bal);
            account.MakeDeposit(bal);

            accountsList.Add(account);
        }

        private static void ListAccounts()
        {
            if (accountsList.Count == 0)
            {
                Console.WriteLine("NO ACCOUNTS");
            }
            else
            {
                Console.WriteLine("Account\tBalance");
                Console.WriteLine("===============================");
                foreach (BankAccount account in accountsList)
                {
                    Console.WriteLine(account); // WriteLine calls account's ToString() method
                }
                Console.WriteLine("===============================");
           }
            Console.Write("\n\n(press any key to continue)");
            Console.ReadKey();
        }

        private static void PrintWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
*********************************************
*      Welcome to NYU LEARNING BANK         *
**********************************************");
            Console.ResetColor();

            Console.Write("Accounts: [C]reate");
            
            if (accountsList.Count > 0)
                Console.Write(" | [L]ist | [D]eposit | [W]ithdraw | [B]alance");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nCommand: ");
            Console.ResetColor();
        }

        private static BankAccount PromptForAccount()
        {
            Console.Write("Account Number: ");
            uint val;
            uint.TryParse(Console.ReadLine(), out val);

            foreach (BankAccount a in accountsList)
            {
                if (a.AccountNumber == val)
                {
                    return a;
                }
            }
            return null;
        }

    }

    /// <summary>
    /// this should be in its own source code file BankAccount.cs
    /// </summary>
    public class BankAccount
    {
        uint _acctnumber;
        decimal _balance = 0.0M;

        public BankAccount(uint acctNum)
        {
            _acctnumber = acctNum;
        }

        public uint AccountNumber
        {
            get { return _acctnumber; }
            private set { _acctnumber = value; }
        }
        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        public decimal MakeDeposit(decimal amount)
        {
            if (amount <= 0)
            {
                return _balance;
            }
            _balance += amount;
            return _balance;
        }

        public decimal MakeWithdrawl(decimal amount)
        {
            if (amount > _balance)
            {
                throw new ApplicationException("You don't have enough money!");
            }

            _balance -= amount;
            return _balance;
        }

        //override this method and format the output
        public override string ToString()
        {
            return string.Format("{0}\t{1}", AccountNumber, Balance);
        }
    }
}