using DAL.Models;
using System.Collections.Generic;

namespace Business.ViewModels
{
    public class ShopVM
    {
        public List<ProductDetail> ProductDetails { get; set; }
        public List<Product> Products { get; set; }
        public List<BlogDetail> BlogDetails { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
