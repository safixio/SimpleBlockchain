using SimpleBlockchain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Service.Interfaces
{
    public interface IBlockContainer
    {
        public void AddBlock(Block block);

        public Block GetLastBlock();

        public List<Block> GetAllBlocks();
    }
}
