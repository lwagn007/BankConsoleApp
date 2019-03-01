using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public Person AccountOwner { get; set; }
        public string AccountPassword { get; set; }
        public decimal AccountChecking { get; set; }
        public decimal AccountSaving { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Account(Person person, string password, decimal depositChecking, decimal depositSaving)
        {
            AccountNumber = AccountNumberCreate();
            AccountOwner = person;
            AccountPassword = password;
            AccountChecking = depositChecking;
            AccountSaving = depositSaving;
        }

        private int AccountNumberCreate()
        {
            int min = 200000;
            int max = 900000;
            Random random = new Random();
            int number = random.Next(min, max);
            return number;
        }

        public Account()
        {

        }
    }
}
