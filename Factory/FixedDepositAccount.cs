﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class FixedDepositAccount : IAccount
    {
        public void PrintDetails(string accountHolderName, string accountNumber)
        {
            Console.WriteLine($"Congratulations {accountHolderName}!!! You have successfully opened your fixed deposit account.\nYour account number is {accountNumber}.");
        }
    }
}
