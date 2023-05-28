using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSync.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocuments Idocuments;
        public DocumentController(IDocuments documents)
        {
            Idocuments = documents;
         
            
        }
                [HttpPost("create-document")]
        public async Task<IActionResult> Createdocument([FromForm] Documents document)
        {
            var response = await Idocuments.CreateDocumentsAsync(document);
            return Ok(response);
        }

        [HttpGet("fetch")]
        public async Task<IActionResult> FetchAll(int pageSize = 10, int currentPage = 1)
        {
            var response = await Idocuments.FetchAll(pageSize, currentPage);
            return Ok(response);
        }
    }
}