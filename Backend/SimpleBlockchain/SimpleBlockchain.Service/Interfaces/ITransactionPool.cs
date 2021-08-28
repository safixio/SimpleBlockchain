using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SimpleBlockchain.Service.Interfaces
{
    interface ITransactionPool
    {
        void AddTransaction(Transaction transaction);

        List<Transaction> GetTransactions();
    }
}
