using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSync.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentAutorunController : ControllerBase
    {

        private readonly IDocumentAutorun IdocumentAutorun;
        public DocumentAutorunController(IDocumentAutorun documentAutorun)
        {
            IdocumentAutorun = documentAutorun;

        }
        [HttpPost("create-documentAutorun")]
        public async Task<IActionResult> CreatedocumentAutorun([FromForm] DocumentAutorun document)
        {
            var response = await IdocumentAutorun.CreateDocumentAutorunAsync(document);
            return Ok(response);
        }

        [HttpGet("fetch")]
        public async Task<IActionResult> FetchAll(int pageSize = 10, int currentPage = 1)
        {
            var response = await IdocumentAutorun.FetchAll(pageSize, currentPage);
            return Ok(response);
        }
    }
}