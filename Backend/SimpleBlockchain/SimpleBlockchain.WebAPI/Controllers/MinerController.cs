using Microsoft.AspNetCore.Mvc;
using SimpleBlockchain.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlockchain.WebAPI.Controllers
{
    [Route("api/v1/miner")]
    public class MinerController : Controller
    {
        private readonly IMiner _miner;

        public MinerController(IMiner miner)
        {
            _miner = miner;
        }

        [HttpGet("start")]
        public IActionResult Start()
        {
            _miner.Start();
            return Ok("Success");
        }

        [HttpGet("stop")]
        public IActionResult Stop()
        {
            _miner.Stop();
            return Ok("Stop");
        }
    }
}
