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
            AccountNumber = AccountNumberCreate(person);
            AccountOwner = person;
            AccountPassword = password;
            AccountChecking = depositChecking;
            AccountSaving = depositSaving;
        }

        private int AccountNumberCreate(Person person)
        {

            int number = person.SocialSecurityNumber + person.DateOfBirth.Year + person.DateOfBirth.Month + person.DateOfBirth.Day;

            return number;
        }

        public Account()
        {

        }
    }
}
