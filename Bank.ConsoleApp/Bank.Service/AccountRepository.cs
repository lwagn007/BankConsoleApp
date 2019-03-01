using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp
{
    public class AccountRepository : IAccountRepository
    {
        List<Account> _accounts;
        private bool _success = false;

        public AccountRepository()
        {
            _accounts = new List<Account>();
        }

        public bool CreateAccount(Person person, string password, decimal checking, decimal saving)
        {
            if (checking >= 100 && saving >= 100)
            {
                Account account = new Account(person, password, checking, saving);
                if (account.AccountNumber != 0)
                    _success = AddAccount(account);
            }
            else
                _success = false;
            return _success;
        }

        public Account GetUserAccount(int number, string password)
        {
            Account account = new Account();
            foreach (Account userAccount in _accounts)
            {
                if (number == userAccount.AccountNumber && password == userAccount.AccountPassword)
                {
                    account = userAccount;
                }
            }
            return account;
        }

        public bool DeleteAccount(int accountNumber, string password, int socialSecurityNumber, DateTime dateOfBirth)
        {
            foreach (Account account in _accounts)
            {
                if (account.AccountNumber == accountNumber &&
                    account.AccountPassword == password &&
                    account.AccountOwner.SocialSecurityNumber == socialSecurityNumber &&
                    account.AccountOwner.DateOfBirth == dateOfBirth)
                {
                    return _success = RemoveAccount(account);
                }
            }
            return _success;
        }

        private bool AddAccount(Account account)
        {
            _accounts.Add(account);
            return _success = true;
        }

        public List<Account> GetAccounts()
        {
            return _accounts;
        }

        private bool RemoveAccount(Account account)
        {
            return _accounts.Remove(account);
        }
    }
}
