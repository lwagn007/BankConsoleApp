using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp
{
    interface IAccountRepository
    {
        bool CreateAccount(Person person, string password, decimal checking, decimal saving);
        bool UpdateAccount(int accountNumber, string password);
        bool DeleteAccount(int accountNumber, string password, string socialSecurityNumber, DateTime dateOfBirth);
        List<Account> GetAccounts();
        Account GetUserAccount(int number, string password);
    }
}
