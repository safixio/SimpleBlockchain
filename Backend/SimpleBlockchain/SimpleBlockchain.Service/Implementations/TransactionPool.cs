using SimpleBlockchain.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SimpleBlockchain.Service.Implementations
{
    public class TransactionPool : ITransactionPool
    {
        private List<Transaction> _transactions;
        private object _object;

        public TransactionPool()
        {
            _transactions = new List<Transaction>();
            _object = new object();
        }

        public void AddTransaction(Transaction transaction)
        {
            lock (_object)
            {
                _transactions.Add(transaction);
            }
        }

        public List<Transaction> GetTransactions()
        {
            lock(_object)
            {
                return _transactions;
            }
        }
    }
}
