using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SavingsAccount: IAccount
    {
        public void PrintDetails(string accountHolderName , string accountNumber)
        {
            Console.WriteLine($"Congratulations {accountHolderName}!!! You have successfully opened your savings account.\nYour account number is {accountNumber}.");

        }
    }
}
