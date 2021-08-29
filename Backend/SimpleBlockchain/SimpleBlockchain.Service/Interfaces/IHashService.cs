using SimpleBlockchain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Service.Interfaces
{
    public interface IHashService
    {
        string CalculateHash(string rawData);
        string CalculateHash(List<Transaction> transactions);
    }
}
