﻿using SimpleBlockchain.Service.Interfaces;
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

        public Miner()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            _isStarted = false;
        }

        public void Start()
        {
            if(!_isStarted)
            {
                Task.Run(() => GenerateNewBlock(), _cancellationTokenSource.Token);
                _isStarted = true;
            }
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
            _isStarted = false;
        }

        private void GenerateNewBlock()
        {

        }
    }
}
