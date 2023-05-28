using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSync.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployees Iemployees;

        public EmployeesController(IEmployees employees)
        {
            Iemployees = employees;
        }
        [HttpPost("create-employees")]
        public async Task<IActionResult> CreateEmployees([FromForm] Employees employees)
        {
            var response = await Iemployees.CreateEmployeesTypeAsync(employees);
            return Ok(response);
        }

        [HttpGet("fetch")]
        public async Task<IActionResult> FetchAll(int pageSize = 10, int currentPage = 1)
        {
            var response = await Iemployees.FetchAll(pageSize, currentPage);
            return Ok(response);
        }
    }
}