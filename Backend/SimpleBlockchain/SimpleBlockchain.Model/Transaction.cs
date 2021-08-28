using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Model
{
    public class Transaction
    {
        public string Amount { get; set; }
        public string From { get; set; }
        public string To { get; set; }
    }
}
