using PersonalBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Interface
{
    interface IDataService
    {
        Task Create(Post model);
        Task<List<Post>> GetAll();
    }
}
