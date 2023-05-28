using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolSync.DAL.Repositories.Response;
using SchoolSync.DAL.Entities;

namespace SchoolSync.DAL.Repositories.Interfaces
{
    public interface IPositionRepository
    {
        Task<string> CreatePositionAsync(Position position);
        Task<ResponsePagination> FetchAll(int pageSize, int currentPage);
        Task<bool> DeleteData(int code);
    }
}