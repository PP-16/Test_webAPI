using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolSync.DAL.EFCore;
using SchoolSync.DAL.Entities;
using SchoolSync.DAL.Repositories.Interfaces;
using SchoolSync.DAL.Repositories.Response;

namespace SchoolSync.DAL.Repositories.Queries
{
    public class QPosition : IPositionRepository
    {
        private readonly SchoolSyncDbContext db;

        public QPosition(SchoolSyncDbContext dbContext)
        {
            db = dbContext;
        }
        public async Task<string> CreatePositionAsync(Position position)
        {
            await db.Position.AddAsync(position);
            await db.SaveChangesAsync();
            return "เพิ่มข้อมูลเรียบร้อยแล้ว";
        }

        public async Task<bool> DeleteData(int code)
        {
            var query = db.Division.FirstOrDefault(x => x.DivisionCode.Equals(code));
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

        public async Task<ResponsePagination> FetchAll(int pageSize, int currentPage)
        {
            var query = await db.Position.ToListAsync<object>();
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
    }
}