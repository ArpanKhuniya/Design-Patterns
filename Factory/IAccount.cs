using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IAccount
    {
        public void PrintDetails(string accountHolderName, string accountName);
    }
}
