using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class BlogVM
    {
        public List<BlogDetail> BlogDetails { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Category> Categories { get; set; }
    }
}
