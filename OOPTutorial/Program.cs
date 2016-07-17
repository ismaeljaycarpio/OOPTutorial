using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount oCheckingAccount = new CheckingAccount();
            double balance;
            oCheckingAccount.AccountNumber = 1000;
            balance = oCheckingAccount.AccountNumber;
            oCheckingAccount.Withdraw(500);
        }
    }
}
