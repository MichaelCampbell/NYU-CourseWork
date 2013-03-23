using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nyu.lab3._1
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(Guid AcctID, bool newAcct)
            : base(Guid.NewGuid())
        {
           
        }
    }
}
