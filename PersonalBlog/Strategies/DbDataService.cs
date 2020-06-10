using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonalBlog.Interface;
using PersonalBlog.Models;

namespace PersonalBlog.Strategies
{
    public class DbDataService : IDataService
    {
        public Task Create(Post model)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
