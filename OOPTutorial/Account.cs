using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTutorial
{
    class Account
    {
        private long _accountNumber;

        public long AccountNumber
        {
            get { return _accountNumber;  }
            set { _accountNumber = value; }
        }

        public double GetBalance()
        {
            //retrieve account balance
            return (double)10000;
        }
    }

    class CheckingAccount : Account
    {
        private double _minBalance;

        public double MinBalance
        {
            get { return _minBalance; }
            set { _minBalance = value; }
        }

        public void Withdraw(double amount)
        {
            
        }
    }
}
