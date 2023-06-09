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
    public class DevisionController : ControllerBase
    {
         private readonly IDivisionRepository iDivision;
        public DevisionController(IDivisionRepository division)
        {
            iDivision = division;
        }

        [HttpPost("create-division")]
        public async Task<IActionResult> CreateDivision([FromForm] Division division)
        {
            var response = await iDivision.CreateDivisionAsync(division);
            return Ok(response);
        }

        [HttpGet("fetch")]
        public async Task<IActionResult> FetchAll(int pageSize = 10, int currentPage = 1)
        {
            var response = await iDivision.FetchAll(pageSize, currentPage);
            return Ok(response);
        }
    }
}