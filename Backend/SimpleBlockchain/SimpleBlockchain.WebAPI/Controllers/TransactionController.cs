using Microsoft.AspNetCore.Mvc;
using SimpleBlockchain.Model;
using SimpleBlockchain.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlockchain.WebAPI.Controllers
{
    [Route("api/v1/transactions")]
    public class TransactionController : Controller
    {
        private readonly ITransactionPool _transactionPool;
        public TransactionController(ITransactionPool transactionPool)
        {
            _transactionPool = transactionPool;
        }

        [HttpPost("add")]
        public IActionResult Add(Transaction transaction)
        {
            _transactionPool.AddTransaction(transaction);
            return Ok("Success");
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            List<Transaction> transactions = _transactionPool.GetTransactions();
            return Ok(transactions);
        }
    }
}
