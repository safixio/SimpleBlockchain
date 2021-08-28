using SimpleBlockchain.Model;
using SimpleBlockchain.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlockchain.Service.Implementations
{
    public class BlockContainer : IBlockContainer
    {
        private List<Block> _blockLists;
        private object _object;

        public BlockContainer()
        {
            _blockLists = new List<Block>();
            _object = new object();
        }

        public void AddBlock(Block block)
        {
            lock (_object)
            {
                _blockLists.Add(block);
            }
        }

        public List<Block> GetAllBlocks()
        {
            lock (_object)
            {
                return _blockLists.ToList();
            }
        }

        public Block GetLastBlock()
        {
            lock (_object)
            {
                return _blockLists.Last();
            }
        }
    }
}
