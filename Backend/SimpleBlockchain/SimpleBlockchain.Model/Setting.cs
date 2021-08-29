using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Model
{
    public class Setting
    {
        public int MinerDelay { get; set; }
        public string MinerReward { get; set; }
        public int MiningDifficulty { get; set; }
    }
}
