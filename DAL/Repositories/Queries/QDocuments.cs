using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSync.DAL.Repositories.Queries
{
    public class QDocuments : IDocuments
    {
        private readonly SchoolSyncDbContext db;
        public QDocuments(SchoolSyncDbContext schoolSyncDb)
        {
            db = schoolSyncDb;

        }

        public async Task<string> CreateDocumentsAsync(Documents documents)
        {
            await db.Documents.AddAsync(documents);
            await db.SaveChangesAsync();
            return "เพิ่มข้อมูลเรียบร้อยแล้ว";
        }

        public async Task<ResponsePagination> FetchAll(int pageSize, int currentPage)
        {
            var query = await db.Documents.ToListAsync<object>();
   Pagination pagination = new Pagination(query,currentPage,pageSize);
            // int totalRow = 0;
            // totalRow = query.Count;
            // var totalPage = (double)totalRow / pageSize;
            // var value = query.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            // totalPage = (int)Math.Ceiling(totalPage);

            return new ResponsePagination
            {
                StatusCode = 200,
                TaskStatus = true,
                Message = "สำเร็จ",
                Pagin = new
                {
                    CurrentPage = currentPage,
                    PageSize = pageSize,
                    TotalRows = pagination.TotalRow,
                    TotalPages = pagination.TotalPage
                },
                Data = pagination.Data
            };
        }
          //ลบข้อมูล
        public async Task<bool> DeleteData(int code)
        {
            var query = db.Documents.FirstOrDefault(x => x.Code.Equals(code));
            query.IsUsed = query.IsUsed.ToString() == "1" ? "0" : "1";
            db.Entry(query).State = EntityState.Modified;
            int save = await db.SaveChangesAsync();
            if (save > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}