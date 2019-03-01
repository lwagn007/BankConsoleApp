using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.ConsoleApp
{
    public enum TransactionType { Withdrawal, Deposit }

    public class Transaction
    {
        public int TransactionID { get; set; }
        public DateTimeOffset TransactionDate { get; set; }
        public TransactionType TransactionType { get; set; }
        public string TransactionDescription { get; set; }
    }
}
