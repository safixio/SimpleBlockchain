using Microsoft.Extensions.Options;
using SimpleBlockchain.Model;
using SimpleBlockchain.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleBlockchain.Service.Implementations
{
    public class Miner : IMiner
    {
        private CancellationTokenSource _cancellationTokenSource;
        private bool _isStarted;
        private IBlockContainer _blockContainer;
        private ITransactionPool _transactionPool;
        private Setting _setting;

        public Miner(IBlockContainer blockContainer, ITransactionPool transactionPool, IOptions<Setting> setting)
        {
            _transactionPool = transactionPool;
            _blockContainer = blockContainer;
            _cancellationTokenSource = new CancellationTokenSource();
            _isStarted = false;
            _setting = setting.Value;
        }

        public void Start()
        {
            if(!_isStarted)
            {
                Task.Run(() => DoMine(), _cancellationTokenSource.Token);
                _isStarted = true;
            }
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            _isStarted = false;
        }

        private void DoMine()
        {
            while(true)
            {
                GenerateBlock();
                Thread.Sleep(_setting.MinerDelay);
            }
        }

        private void GenerateBlock()
        {
            Block lastBlock = _blockContainer.GetLastBlock();
            List<Transaction> transactions = _transactionPool.GetTransactions();
            transactions.Add(new Transaction()
            {
                From = "-",
                To = "Miner",
                Amount = _setting.MinerReward
            });

            Block newBlock = new Block()
            {
                Index = (lastBlock?.Index) + 1 ?? 0,
                TimeStamp = DateTime.UtcNow,
                PrevHash = lastBlock?.PrevHash ?? "",
                Transactions = transactions
            };

            _blockContainer.AddBlock(newBlock);
        }
    }
}
