using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp
{
    public interface ITransactionRepository
    {
        bool Withdrawal(Account account, decimal amount);
    }
}
