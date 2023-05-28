using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolSync.DAL.Entities;
using SchoolSync.DAL.Repositories.Response;

namespace SchoolSync.DAL.Repositories.Interfaces
{
    public interface IDivisionRepository
    {
        Task<string> CreateDivisionAsync(Division division);
        Task<ResponsePagination> FetchAll(int pageSize, int currentPage);
        Task<bool> DeleteData(int code);
    }
}