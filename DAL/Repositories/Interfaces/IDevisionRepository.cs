using SchoolSync.DAL.Entities;
using SchoolSync.DAL.Repositories.Response;

namespace SchoolSync.DAL.Repositories.Interface
{
    public interface IDevisionRepository
    {
        Task<string> CreateDivisionAsync(Division division);
        Task<ResponsePagination> FetchAll(int pageSize, int currentPage);
        Task<bool> DeleteData(string code);
    }
}