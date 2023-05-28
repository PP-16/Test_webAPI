using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSync.DAL.Repositories.Interfaces
{
    public interface IDocumentType
    {
        Task<string> CreateDocumentTypeAsync(DocumentType documentType);
        Task<ResponsePagination> FetchAll(int pageSize, int currentPage);
        Task<bool> DeleteData(int code);
    }
}