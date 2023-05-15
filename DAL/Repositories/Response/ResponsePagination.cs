using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSync.DAL.Repositories.Response
{
    public class ResponsePagination
    {
          public int StatusCode { get; set; }
        public bool TaskStatus { get; set; } = false;
        public string Message { get; set; }
        public object Pagin { get; set; }
        public object Data { get; set; } = new object();
    }
}