using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Service.Interfaces
{
    interface IMiner
    {
        void Start();
        void Stop();
    }
}
