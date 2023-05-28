using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolSync.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocumentTypeController : ControllerBase
    {
        private readonly IDocumentType IdocumentType;
        public DocumentTypeController(IDocumentType documentType)
        {
            IdocumentType = documentType;

        }
        [HttpPost("create-documentType")]
        public async Task<IActionResult> CreateDocumentType([FromForm] DocumentType documentType)
        {
            var response = await IdocumentType.CreateDocumentTypeAsync(documentType);
            return Ok(response);
        }

        [HttpGet("fetch")]
        public async Task<IActionResult> FetchAll(int pageSize = 10, int currentPage = 1)
        {
            var response = await IdocumentType.FetchAll(pageSize, currentPage);
            return Ok(response);
        }
    }
}