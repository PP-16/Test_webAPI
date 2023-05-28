using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolSync.DAL.Entities;
using SchoolSync.DAL.Repositories.Interfaces;

namespace SchoolSync.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionController : ControllerBase
    {
        private readonly IPositionRepository iposition;
        public PositionController(IPositionRepository iposition)
        {
            this.iposition = iposition;
            
        }
          [HttpPost("create-division")]
        public async Task<IActionResult> CreatePosition([FromForm] Position position )
        {
            var response = await iposition.CreatePositionAsync(position);
            return Ok(response);
        }

        [HttpGet("fetch")]
        public async Task<IActionResult> FetchAll(int pageSize = 10, int currentPage = 1)
        {
            var response = await iposition.FetchAll(pageSize, currentPage);
            return Ok(response);
        }
    }
}