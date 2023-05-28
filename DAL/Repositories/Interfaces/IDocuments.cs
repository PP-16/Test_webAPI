using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSync.DAL.Repositories.Interfaces
{
    public interface IDocuments
    {
        Task<string> CreateDocumentsAsync(Documents documents);
        Task<ResponsePagination> FetchAll(int pageSize, int currentPage);
             Task<bool> DeleteData(int code);
    }
}