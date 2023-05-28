using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSync.DAL.Repositories.Interfaces
{
    public interface IEmployees
    {
        Task<string> CreateEmployeesTypeAsync(Employees employees);
        Task<ResponsePagination> FetchAll(int pageSize, int currentPage);
        Task<bool> DeleteData(int code);
    }
}