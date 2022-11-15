using DAL.Models;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class BlogVM
    {
        public List<BlogDetail> BlogDetails { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Category> Categories { get; set; }
    }
}
