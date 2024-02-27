using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class AccountFactory
    {
        public static IAccount CreateAccount(string accountType)
        {
            switch (accountType)
            {
                case "savings":
                    return new SavingsAccount();
                case "current":
                    return new CurrentAccount();
                case "fixed deposit":
                    return new FixedDepositAccount();
                default:
                    throw new ArgumentException("Invalid Account Type!!");
            }
        }

    }
}
