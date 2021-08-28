using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Model
{
    public class Block
    {
        public Block()
        {
            Transactions = new List<Transaction>();
        }

        public long Index { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Hash { get; set; }
        public string PrevHash { get; set; }
        public long Nonce { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
