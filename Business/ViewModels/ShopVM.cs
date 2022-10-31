using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels
{
    public class ShopVM
    {
        public List<ProductDetail> ProductDetails { get; set; }
        public List<Product> Products { get; set; }

    }
}
