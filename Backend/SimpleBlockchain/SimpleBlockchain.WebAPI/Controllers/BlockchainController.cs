using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBlockchain.Model;
using SimpleBlockchain.Service.Interfaces;

namespace SimpleBlockchain.WebAPI.Controllers
{
    [Route("api/v1/blockchain")]
    public class BlockchainController : Controller
    {
        private readonly IBlockContainer _blockContainer;
        public BlockchainController(IBlockContainer blockContainer)
        {
            _blockContainer = blockContainer;
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            List<Block> blocks = _blockContainer.GetAllBlocks();
            return Ok(blocks);
        }

    }
}
