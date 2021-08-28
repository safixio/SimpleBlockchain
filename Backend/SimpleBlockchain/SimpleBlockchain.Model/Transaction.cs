using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Model
{
    public class Transaction
    {
        public Transaction() { }
        public Transaction(string from, string to, string amount)
        {
            Amount = amount;
            From = from;
            To = to;
        }
        public string Amount { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
