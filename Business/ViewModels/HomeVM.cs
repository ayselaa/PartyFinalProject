using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class HomeVM
    {
        public List<HomeBox> HomeBoxes { get; set; }
        public List<Service> Services { get; set; }
        public List<ServiceDetail> ServiceDetails { get; set; }
        public List<Image> Images { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<BlogDetail>  BlogDetails { get; set; }
        public List<Product> Products { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
        public List<TeamDetail> TeamDetails { get; set; }
        public List<Team> Teams { get; set; }
        public List<Gallery> Galleries  { get; set; }

    }
}
