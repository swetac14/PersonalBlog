using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalBlog.Models
{
    public class Post
    {

        public string Id { get; set; }
        public DateTime PostDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
