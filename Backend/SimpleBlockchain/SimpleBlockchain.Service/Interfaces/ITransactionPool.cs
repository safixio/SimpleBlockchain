using SimpleBlockchain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Service.Interfaces
{
    public interface ITransactionPool
    {
        void AddTransaction(Transaction transaction);

        List<Transaction> GetTransactions();
    }
}
